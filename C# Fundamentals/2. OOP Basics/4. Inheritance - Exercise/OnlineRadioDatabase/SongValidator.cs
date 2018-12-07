namespace OnlineRadioDatabase
{
    public static class SongValidator
    {
        public static void Song(string[] details)
        {
            if (details.Length != 3)
            {
                throw new InvalidSongException();
            }
        }
        public static void Artist(string artist)
        {
            if (artist.Length < 3 || artist.Length > 20)
            {
                throw new InvalidArtistNameException();
            }
        }
        public static void SongName(string name)
        {
            if (name.Length < 3 || name.Length > 30)
            {
                throw new InvalidSongNameException();
            }
        }
        public static void SongLength(string length)
        {
            var attrs = length.Split(':');
            if (attrs.Length != 2)
            {
                throw new InvalidSongLengthException();
            }
            int totalLength = int.Parse(attrs[0]) * 60 + int.Parse(attrs[1]);
            if (totalLength < 0 || totalLength > (14 * 60 + 59))
            {
                throw new InvalidSongLengthException();
            }
            Minutes(int.Parse(attrs[0]));
            Seconds(int.Parse(attrs[1]));
        }
        public static void Minutes(int minutes)
        {
            if (minutes < 0 || minutes > 14)
            {
                throw new InvalidSongMinutesException();
            }
        }
        public static void Seconds(int seconds)
        {
            if (seconds < 0 || seconds > 14)
            {
                throw new InvalidSongSecondsException();
            }
        }
    }
}
namespace OnlineRadioDatabase
{
    using System.Collections.Generic;
    public class Track
    {
        public List<string> Songs;
        public decimal TotalLength;
        public Track()
        {
            Songs = new List<string>();
        }

        public void AddSong(string song)
        {
            this.Songs.Add(song);
            System.Console.WriteLine("Song added.");
            var attrs = length.Split(':');
            
            int totalLength = int.Parse(attrs[0]) * 60 + int.Parse(attrs[1]);
        }
    }
}
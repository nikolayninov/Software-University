using System;

namespace OnlineRadioDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            Track track = new Track();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ');

                try
                {
                    SongValidator.Song(input);

                    string artist = input[0];
                    string song = input[1];
                    string length = input[2];

                    SongValidator.Artist(artist);
                    SongValidator.Song(song);
                    SongValidator.SongLength(length);
                    track.AddSong(length);
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.Message);
                }

            }
        }
    }
}
namespace OnlineRadioDatabase
{
    using System;
    public class InvalidSongException : Exception
    {
        public override string Message => "Indalid song.";
    }
}
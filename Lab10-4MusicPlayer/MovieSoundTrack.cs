using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10_4MusicPlayer
{
    class MovieSoundTrack : IAudioPlayer
    {
        public string movieName { get; }
        public string trackName { get; }

        public MovieSoundTrack (string movieName, string trackName)
        {
            this.movieName = movieName;
            this.trackName = trackName;
        }

        public void Play()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Now Playing ");
            sb.Append(movieName);
            sb.Append(" ");
            sb.Append(trackName);
            Console.WriteLine(sb.ToString());
        }
    }
}

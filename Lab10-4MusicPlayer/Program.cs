using System;

namespace Lab10_4MusicPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World Lab10-4!");
            Artist AvengedSevenfold = new Artist("Avenged Sevenfold");
            AvengedSevenfold.AddToPlaylist("Dear God");
            AvengedSevenfold.AddToPlaylist("So Far Away");
            AvengedSevenfold.AddToPlaylist("Hail to the King");
            AvengedSevenfold.AddToPlaylist("A Little Piece of Heaven");

            MediaPlayer player = new MediaPlayer();
            player.PlayMedia(AvengedSevenfold);

            AudioBook theSix = new AudioBook("Daisy Jones & The Six", "Taylor Jenkins Reid");
            player.PlayMedia(theSix);

            MovieSoundTrack starWars = new MovieSoundTrack("Star Wars", "Imperial March");
            player.PlayMedia(starWars);
        }
    }
}

using System;

namespace Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Song[] arrayOfSongs = new Song[5];

            for (int i = 0; i < arrayOfSongs.Length; i++ )
            {
                Song newSong = InputSongDetails();
                arrayOfSongs[i] = newSong;
            }

            Console.WriteLine("Enter an artist name, or just press Return for all artists");
            string inputtedArtist = Console.ReadLine();

            foreach(var song in arrayOfSongs)
            {
                if (inputtedArtist == song.GetArtist() || inputtedArtist == "")
                {
                    Console.WriteLine(song.GetDetails());
                    Console.WriteLine("The song was awarded {0}", song.GetCertification() == null ? "no award!" : song.GetCertification());
                    Console.WriteLine("---------------------");
                }
            }
        }

        static Song InputSongDetails()
        {
            Console.WriteLine("Please enter the name of the song");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter the name of the artist");
            string artist = Console.ReadLine();

            Console.WriteLine("Please enter the number of copies sold");
            string copiesSoldString = Console.ReadLine();

            int copiesSoldInt;
            if (!int.TryParse(copiesSoldString, out copiesSoldInt))
            {
                Console.WriteLine("Please enter numbers only");
                copiesSoldInt = 0;
            }

            return new Song(name, artist, copiesSoldInt);
        }
    }
}

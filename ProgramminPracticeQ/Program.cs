using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramminPracticeQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Song s1 = new Song("Beautiful People", "Ed Sheeran", 3.15, Genre.Pop);
            Song s2 = new Song("Dance Monkey", "Tones & I", 4.20, Genre.Dance);
            Song s3 = new Song("Circles", "Post Malone", 3.25, Genre.Pop);
            Song s4 = new Song("Ride It", "Regard", 3.37, Genre.Dance);
            Song s5 = new Song("South Of The Border", "Ed Sheeran", 4.26, Genre.Pop);
            
            List<Song> Playlist = new List<Song>();

            Playlist.Add(s1);
            Playlist.Add(s2);
            Playlist.Add(s3);
            Playlist.Add(s4);
            Playlist.Add(s5);

            foreach(Song song in Playlist)
            {
                Console.WriteLine(song);
            }
        }
        private static void Display(List<Song> playlist)
        {
            Console.WriteLine("{0, -20}{1, -25}{2, -10}{3, -10}", "Artist", "Song", "Duration", "Genre");
            foreach(Song song in playlist)
            {
                Console.WriteLine($"{song.Artist,-20}{song.SongTitle,-25}{song.Duration,-10}{song.MusicGenre,-10}");
            }
        }
    }
}

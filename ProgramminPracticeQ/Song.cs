using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramminPracticeQ
{
    public class Song:IComparable
    {
        public string SongTitle { get; set; }
        public string Artist { get; set; }
        public double Duration { get; set; }
        public Genre MusicGenre { get; set; }
        public Song(string songTitle, string artist, double duration, Genre musicGenre)
        {
            SongTitle = songTitle;
            Artist = artist;
            Duration = duration;
            MusicGenre = musicGenre;
        }
        public Song(string songTitle, string artist) : this(songTitle, artist, 0, Genre.Other) { }
        public Song() : this("Unkown", "Unkown") { }
        public override string ToString()
        {
            return string.Format($"{SongTitle} {Artist} {Duration} {MusicGenre}");
        }
        public int CompareTo(object other)
        {
            Song that = (Song)other;
            int returnValue = this.Artist.CompareTo(this.Artist);
            if(returnValue == 0)
            {
                returnValue = this.SongTitle.CompareTo(this.SongTitle);
            }
            return returnValue;
        }
    }
    public enum Genre { Rock, Pop, Dance, Other }
}

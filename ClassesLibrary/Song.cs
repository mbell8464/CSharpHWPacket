using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Song
    {
        //fields

        //properties
        public string Artist { get; set; }
        public string Title { get; set; }
        public int LengthInSeconds { get; set; }
        //constructors
        public Song()
        {

        }

        public Song(string title, string artist)
        {
            Artist = artist;
            Title = title;
            
        }

        public Song(string title, string artist, int lengthInSeconds)
        {
            Artist = artist;
            Title = title;
            LengthInSeconds = lengthInSeconds;
        }


        //methods

        public override string ToString()
        {
            return String.Format($"\nSong Title: {Title}\nArtist: {Artist}\nLength of song in seconds: {LengthInSeconds}");
        }
    }
}

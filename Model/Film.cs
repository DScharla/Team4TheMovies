using System;

namespace theMovies
{
    public class Film
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string duration;

        public string Duration
        {
            get { return duration; }
            set { duration = value; }
        }
        private string genre;

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        public Film(string name, string duration, string genre)
        {
            //string durationFormat = "HH:mm";
            Duration = duration;
            //Duration = TimeOnly.ParseExact(duration, durationFormat, null);     
            Name = name;
            Genre = genre;

        }
        public override string ToString()
        {
            string s;
            s = name + ";" + duration + ";" + genre;
            return s;
        }
    }
}
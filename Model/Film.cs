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
        private TimeSpan duration;

        public TimeSpan Duration
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
        private string director;

        public string Director
        {
            get { return director; }
            set { director = value; }
        }

        private DateOnly premierDate;

        public DateOnly PremierDate
        {
            get { return premierDate; }
            set { premierDate = value; }
        }

        public Film(string name, string duration, string genre, string director, string premierDate)
        {
            Duration = TimeSpanFromString(duration);
            Name = name;
            Genre = genre;
            Director = director;
            PremierDate = DateOnlyFromString(premierDate);

        }
        public override string ToString()
        {
            string s;
            s = name + ";" + genre + ";" + duration.ToString() + ";"+ director + ";" + PremierDate.ToString();
            return s;
        }
        public TimeSpan TimeSpanFromString(string duration)
        {
            return TimeSpan.Parse(duration);
        }
        public DateOnly DateOnlyFromString(string date)
        {
            return DateOnly.Parse(date);
        }
    }
}
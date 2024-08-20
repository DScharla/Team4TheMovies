using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace TheMoviesScenarie1_Bo
{
	public class Film
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Duration { get; set; }

        public Film(string title, string genre, string duration)
        {
            Title = title;
            Genre = genre;
            Duration = duration;
        }

        public override string ToString()
        {
            return $"{Title};{Genre};{Duration}";
        }
    }
}

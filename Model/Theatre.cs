using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using theMovies;

namespace TheMoviesNy.Model
{
    public class Theatre
    {
        private string name;
        private string city;
        private string[] rooms = { "sal 1", "sal 2", "sal 3", "sal 4", "sal 5" };
        private ObservableCollection<Showing> showings;
        public ObservableCollection<Showing> Showings { get { return showings; } set { showings = value; } }

        public Theatre(string name, string city) 
        {
            this.name = name;
            this.city = city;
        }
        public Theatre(string name, string city, string[] rooms)
        {
            this.name = name;
            this.rooms = rooms;
            this.city=city;
        }
        public Theatre(string name, string city, string[] rooms, string[] showings)
        {
            this.name = name;
            this.rooms = rooms;
            this.city = city;
            foreach (string showing in showings)
            {

            }
        }
        public Showing ShowingFromString()
        {

        }
    }
}

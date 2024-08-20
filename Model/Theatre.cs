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
        private string[] rooms = { "sal 1", "sal 2", "sal 3", "sal 4", "sal 5" };
        private ObservableCollection<Showing> showings;
        public ObservableCollection<Showing> Showings { get { return showings; } set { showings = value; } }

        public Theatre(string name) 
        {
            this.name = name;
        }
        public Theatre(string name, string[] rooms)
        {
            this.name = name;
            this.rooms = rooms;
        }
        public Theatre(string name, string[] rooms, string[] showings)
        {
            this.name = name;
            this.rooms = rooms;
            foreach (string showing in showings)
            {

            }
        }
        public Showing ShowingFromString()
        {

        }
    }
}

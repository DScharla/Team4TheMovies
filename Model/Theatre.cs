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
        private ObservableCollection<Showing> showings = new ObservableCollection<Showing>();
        public ObservableCollection<Showing> Showings { get { return showings; } set { showings = value; } }

        public Theatre(string name, string city) 
        {
            this.name = name;
            this.city = city;
        }
        /*public Theatre(string name, string city,)
        {
            this.name = name;
            this.rooms = rooms;
            this.city=city;
        }*/
        public Theatre(string name, string city, string[] showings)
        {
            this.name = name;
            this.city = city;
            foreach (string showing in showings)
            {

            }
        }
        public override string ToString()
        {
            return name + ";" + city + ";" + showings[0].ToString();
        }

        public string[] showingsToString(ObservableCollection<Showing> showings)
        {
            string[] showingsStrings = new string[Showings.Count];

            for (int i = 0; i<Showings.Count; i++)
            {
                showingsStrings[i] = Showings[i].ToString() + ",";
            }
            return showingsStrings;
        }

        public void AddShowing(Showing showing)
        {
            showings.Add(showing);
        } 
    }
}

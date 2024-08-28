using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using theMovies;
using TheMoviesNy.Data.Repositories;
using TheMoviesNy.Model;

namespace TheMoviesNy.ViewModel
{
    internal class TheatreViewModel : IObserver
    {
        private ObservableCollection<object> theatreList;
        public ObservableCollection<object> TheatreList { get { return theatreList; } }

        private TheatreRepository theatreRepository;
        public TheatreRepository TheatreRepository
        {
            get { return theatreRepository; }
            set { theatreRepository = value; }
        }

        public RelayCommand AddCommand => new RelayCommand(execute => AddTheatre(Name, City), canExecute => { return true; }); //canExecute er et hvilketsomhelst (valgfrit) udtryk, der returnere en bool. Hvis den returnere true, køres denne command. Hvis ikke, så køre den ikke.

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string city;

        public string City
        {
            get { return city; }
            set { city = value; }
        }
        private string phone;

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        private string mail;

        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }

        public TheatreViewModel()
        {
            theatreRepository = new TheatreRepository();
            theatreRepository.Attach(this);

            theatreList = theatreRepository.RepoList;
        }
        private void AddTheatre(string name, string city)
        {
            Theatre theatre = new Theatre(name, city);
            theatreRepository.Add(theatre);
        }

        public void Update(ObservableCollection<object> repoList)
        {
            theatreList = repoList;
        }
    }
}

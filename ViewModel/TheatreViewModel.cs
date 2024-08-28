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
    public class TheatreViewModel : IObserver
    {
        private FilmRepository filmRepository;

        private ObservableCollection<object> theatreList;
        public ObservableCollection<object> TheatreList { get { return theatreList; } }

        private TheatreRepository theatreRepository;
        public TheatreRepository TheatreRepository
        {
            get { return theatreRepository; }
            set { theatreRepository = value; }
        }

        public RelayCommand AddCommand => new RelayCommand(execute => AddTheatreWithShowing(Name, City, FilmName, Date, Time, "Room" /*placeholder*/, Mail, Phone), canExecute => { return true; }); //canExecute er et hvilketsomhelst (valgfrit) udtryk, der returnere en bool. Hvis den returnere true, køres denne command. Hvis ikke, så køre den ikke.

        private string date;

        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        private string time;

        public string Time
        {
            get { return time; }
            set { time = value; }
        }

        private string showingTime;

        public string ShowingTime
        {
            get { return showingTime; }
            set { showingTime = value; }
        }

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

        private string filmName;

        public string FilmName
        {
            get { return filmName; }
            set { filmName = value; }
        }


        public TheatreViewModel(FilmRepository filmrepository)
        {
            theatreRepository = new TheatreRepository();
            theatreRepository.Attach(this);
            this.filmRepository = filmrepository;
            filmRepository.Attach(this);

            theatreList = theatreRepository.RepoList;
        }
        private void AddTheatreWithShowing(string name, string city, string filmName, string date, string time, string room, string mail, string phone)
        {
            //string date, string timeStart, string? room, string mail, string phone
            Film film = filmRepository.GetByName(filmName);
            Showing showing = new Showing(film, date, time, room, mail, phone);
            Theatre theatre = new Theatre(name, city, showing);
            theatreRepository.Add(theatre);
        }

        public void Update(ObservableCollection<object> repoList)
        {
            theatreList = repoList;
        }
    }
}

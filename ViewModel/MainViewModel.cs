using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheMoviesNy.Data.Repositories;
using TheMoviesNy.ViewModel;

namespace theMovies
{
    public class MainViewModel : IObserver
    {
        //private FilmViewModel filmViewModel;

        private ObservableCollection<object> filmList;
        public ObservableCollection<object> FilmList { get { return filmList; }}

        private TheatreRepository filmRepository;
        public TheatreRepository FilmRepository {  
            get { return filmRepository; }
            set { filmRepository = value; }
        }

        public RelayCommand AddCommand => new RelayCommand(execute => AddFilm(Name, Genre, Duration, Director, PremierDate), canExecute => { return true; }); //canExecute er et hvilketsomhelst (valgfrit) udtryk, der returnere en bool. Hvis den returnere true, køres denne command. Hvis ikke, så køre den ikke.

        private string name;
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string genre;

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }
        private string duration;

        public string Duration
        {
            get { return duration; }
            set { duration = value; }
        }
        private string director;

        public string Director
        {
            get { return director; }
            set { director = value; }
        }
        private string premierDate;

        public string PremierDate
        {
            get { return premierDate; }
            set { premierDate = value; }
        }

        public MainViewModel() 
        {
            filmRepository = new TheatreRepository();
            filmRepository.Attach(this);

            filmList = filmRepository.RepoList;
        }
        private void AddFilm(string name, string duration, string genre, string director, string premierDate)
        {
            Film film = new Film(name, duration, genre, director, premierDate);
            filmRepository.Add(film);
        }

        public void Update(ObservableCollection<object> repoList)
        {
            filmList = repoList;
        }
    }
}

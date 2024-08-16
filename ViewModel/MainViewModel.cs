using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheMoviesNy.Data.Repositories;
using TheMoviesNy.ViewModel;

namespace theMovies
{
    public class MainViewModel 
    {
        public FilmRepository filmRepository;
        public FilmViewModel filmViewModel;

        private string name;
        public RelayCommand AddCommand => new RelayCommand(execute => AddFilm(Name, Genre, Duration), canExecute => { return true; }); //canExecute er et hvilketsomhelst (valgfrit) udtryk, der returnere en bool. Hvis den returnere true, køres denne command. Hvis ikke, så køre den ikke.
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

        public MainViewModel() 
        {
            filmRepository = new FilmRepository();
            filmViewModel = new FilmViewModel();
        }
        public void AddFilm(string name, string duration, string genre)
        {
            Film film = new Film(name, duration, genre);
            filmRepository.Add(film);
            filmRepository.SaveRepository();
        }

    }
}

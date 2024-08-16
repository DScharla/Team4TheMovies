using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theMovies
{
    public class MainViewModel 
    {
        public FilmRepository filmRepository;
        public FilmViewModel filmViewModel;

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

        public MainViewModel() 
        {
            filmRepository = new FilmRepository();
            filmViewModel = new FilmViewModel();
        }
        public void AddFilm(string name, string genre, string duration)
        {
            Film film = new Film(name, genre, duration);
            filmRepository.Add(film);
            filmRepository.SaveRepository();
        }

    }
}

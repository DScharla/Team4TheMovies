using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMoviesScenarie1_Bo
{
    public class FilmViewModel
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Duration { get; set; }

        public FilmRepository filmRepository;

        public FilmViewModel()
        {
            filmRepository = new FilmRepository();
        }
        public void AddFilm(string title, string genre, string duration)
        {
            Film film = new Film(title, genre, duration);
            filmRepository.Add(film);
            filmRepository.SaveRepository();
        }
    }
}
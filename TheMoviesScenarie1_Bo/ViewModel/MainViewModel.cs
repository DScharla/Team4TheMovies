using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMoviesScenarie1_Bo
{
    public class MainViewModel
    {
        private FilmRepository _repo;

        public ObservableCollection<Film> Films { get; }

        public MainViewModel()
        {
            _repo = new FilmRepository();
            Films = _repo.repoList; 
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheMoviesNy;
using TheMoviesNy.Data.Repositories;
using TheMoviesNy.ViewModel;

namespace theMovies
{
    public class MainViewModel : IObserver
    {
        //private FilmViewModel filmViewModel;

        private ObservableCollection<object> filmList;
        public ObservableCollection<object> FilmList { get { return filmList; }}

        private FilmRepository filmRepository;
        public FilmRepository FilmRepository {  
            get { return filmRepository; }
            set { filmRepository = value; }
        }

        public RelayCommand AddCommand => new RelayCommand(execute => AddFilm(Name, Genre, Duration), canExecute => { return true; }); //canExecute er et hvilketsomhelst (valgfrit) udtryk, der returnere en bool. Hvis den returnere true, køres denne command. Hvis ikke, så køre den ikke.

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
            filmRepository.Attach(this);

            filmList = filmRepository.RepoList;
        }
        private void AddFilm(string name, string duration, string genre)
        {
            Film film = new Film(name, duration, genre);
            filmRepository.Add(film);
        }

        public void Update(ObservableCollection<object> repoList)
        {
            filmList = repoList;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using theMovies;

namespace TheMoviesNy.Data.Repositories
{
    public class FilmRepository : Repository
    {
        public override string RepoName { get; set; } = "FilmRepository";
        public override void LoadRepository()
        {
            using (StreamReader streamReader = new StreamReader(FullPath))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    string[] parts = line.Split(';');
                    Film film = new Film(parts[0], parts[1], parts[2], parts[3], parts[4]);
                    RepoList.Add(film);
                }
            }
        }
        public override object Get(object o)
        {
            throw new NotImplementedException();
        }
        public Film GetByName(string name)
        {
            Film[] films = new Film[RepoList.Count];
            RepoList.CopyTo(films, 0);
            int filmmatch=0;
            int i = 0;
            foreach (Film film in films)
            {
                if (film.Name == name)
                {
                    filmmatch = i;
                    i++;
                }
                i++;
            }
            return (Film)RepoList[filmmatch];
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMoviesScenarie1_Bo
{
    public class FilmRepository : Repository
    {
        public override string RepoName { get; set; } = "FilmRepository.txt";
        public override void LoadRepository()
        {
            if (!File.Exists(FullPath)) 
            {
                using (StreamWriter sw = new StreamWriter(FullPath)) { }
            }
            using (StreamReader streamReader = new StreamReader(FullPath))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;
                    string[] parts = line.Split(';');
                    if (parts.Length < 3) continue;
                    Film film = CreateFilmFromString(parts[0], parts[1], parts[2]);
                    repoList.Add(film);
                }
            }
        }
        private Film CreateFilmFromString(string title, string genre, string duration)
        {
            Film film = new Film(title, genre, duration);

            return film;
        }

        public override void Add(object o1)
        {
            repoList.Add((Film)o1);
        }
        public override object Get(object o)
        {
            throw new NotImplementedException();
        }
        public FilmRepository()
        {
            LoadRepository();
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using theMovies;
using TheMoviesNy.Model;

namespace TheMoviesNy.Data.Repositories
{
    public class TheatreRepository : Repository
    {
        public override string RepoName { get; set; } = "TheatreRepository";
        public override void LoadRepository()
        {
            using (StreamReader streamReader = new StreamReader(FullPath))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    string[] parts = line.Split(';');
                    Film film = new Film(parts[3], parts[4], parts[5], parts[6], parts[7]);
                    DateTime dateTime = DateTime.Parse(parts[2]);
                    DateOnly dateOnly = DateOnly.FromDateTime(dateTime);
                    TimeOnly timeOnly = TimeOnly.FromDateTime(dateTime);
                    Showing showing = new Showing(film, dateOnly, timeOnly, "", parts[8], parts[9]);
                    Theatre theatre = new Theatre(parts[0], parts[1]); //Name, Showings, Sal
                    RepoList.Add(theatre);
                }
            }
        }

        public override object Get(object o)
        {
            throw new NotImplementedException();
        }

/*        public override void LoadRepository()
        {
            throw new NotImplementedException();
        }*/
    }
}

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
                    Theatre theatre = new Theatre(parts[0], parts[1], parts[2], parts[3], parts[4]); //Name, Showings, Sal
                    RepoList.Add(theatre);
                }
            }
        }
        public override object Get(object o)
        {
            throw new NotImplementedException();
        }

        public override void LoadRepository()
        {
            throw new NotImplementedException();
        }
    }
}

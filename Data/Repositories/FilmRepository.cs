using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
/*        private Film CreateFilmFromString(string title, string duration, string genre)
        {
            string dateFormat = "yyyy-MM-dd HH:mm";
            string durationFormat = "HH:mm";

            Film film = new Film(title, duration, genre);

            return film;
        }*/

        //public override void LoadRepository()
        //{
        //    try
        //    {
        //        using (StreamReader streamReader = new StreamReader(FullPath))
        //        {
        //            string line;
        //            while ((line = streamReader.ReadLine()) != null)
        //            {
        //                string[] parts = line.Split(';');
        //                Film film = CreateFilmFromString(parts[0], parts[1], parts[2], parts[3], parts[4], parts[5], parts[6], parts[7]);
        //                repoList.Add(film);
        //            }
        //        }
        //    }
        //    catch
        //    {
        //        throw new Exception("Noget er galt - yikes");
        //    }
        //}
        /*private Film CreateFilmFromString(string theatre, string city, string showingDate, string title, string genre, string duration, string producer, string premierDate, string bookingMail, string bookingPhone)
        {
            string[] genres = genre.Split(','); //Forventer denne giver problemer da der er mellemrum
            foreach (string s in genres) //Denne eleminerer alle mellemrum i string
            {
                s.Trim();
            }
            string dateFormat = "yyyy-MM-dd HH:mm";
            string durationFormat = "HH:mm";

            DateTime dtShowingDate = DateTime.ParseExact(showingDate, dateFormat, null);
            DateTime dtDuration = DateTime.ParseExact(duration, durationFormat, null);
            DateTime dtPremierDate = DateTime.ParseExact(premierDate, dateFormat, null);

        }*/
        public override object Get(object o)
        {
            throw new NotImplementedException();
        }
    }
}
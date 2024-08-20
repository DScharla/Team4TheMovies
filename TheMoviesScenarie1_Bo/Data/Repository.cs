using System;
using System.Collections.ObjectModel;
using System.IO;

namespace TheMoviesScenarie1_Bo
{
    public abstract class Repository
    {
        public string repoDest = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Data");
        public string FullPath { get { return Path.Combine(repoDest, RepoName); } }
        public abstract string RepoName { get; set; }

        public ObservableCollection<Film> repoList = new ObservableCollection<Film>();

        public void CreateRepository()
        {
            using (StreamWriter sw = new StreamWriter(FullPath)) { }
        }
        public void SaveRepository()
        {
            StreamWriter sw = new StreamWriter(FullPath);

            try
            {
                foreach (Film film in repoList)
                {
                    sw.WriteLine(film.ToString());
                }
                    
            }
            catch
            {
                throw;
            }
            finally 
            { 
                sw.Close(); 
            }
        }
        public abstract void LoadRepository();
        public abstract void Add(object o1);

        public void Remove(object o1)
        {
            repoList.Remove((Film)o1);
        }
        public abstract object Get(object o);
    }
}
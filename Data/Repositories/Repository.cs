using System;
using System.Collections.ObjectModel;
using System.IO;

namespace theMovies
{
    public abstract class Repository
    {
        public string repoDest = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
        public string FullPath { get { return Path.Combine(repoDest, RepoName); } }
        public abstract string RepoName { get; set; }

        public ObservableCollection<object> repoList = new ObservableCollection<object>();

        public void CreateRepository()
        {
            StreamWriter sw = new StreamWriter(FullPath);
            sw.Close();
        }
        public void SaveRepository()
        {
            StreamWriter sw = new StreamWriter(FullPath);

            try
            {
                foreach (object o in repoList)
                    sw.WriteLine(o.ToString()); //Denne vil kalde ToString metoden i object klassen og ikke den specifikke klasse fx institution
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
            repoList.Remove(o1);
        }
        public abstract object Get(object o);
    }
}

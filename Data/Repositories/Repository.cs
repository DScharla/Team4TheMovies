using System;
using System.Collections.ObjectModel;
using System.IO;
using TheMoviesNy.Data;
using TheMoviesNy.ViewModel;

namespace theMovies
{
    public abstract class Repository : ISubject
    {
        public string repoDest = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
        public string FullPath { get { return Path.Combine(repoDest, RepoName); } }
        public abstract string RepoName { get; set; }

        private ObservableCollection<object> repoList = new ObservableCollection<object>();
        public ObservableCollection<object> RepoList {
            get {return repoList; }
            set {repoList = value;} 
        }
        public Repository()
        {
            {
                try
                {
                    LoadRepository();
                }
                catch { CreateRepository(); }
            }
        }
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
        public  void Add(object o1)
        {
            RepoList.Add(o1);
            SaveRepository();
        }

        public void Remove(object o1)
        {
            repoList.Remove(o1);
        }
        public abstract object Get(object o);

        public override void Notify()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(RepoList);
            }
        }
    }
}

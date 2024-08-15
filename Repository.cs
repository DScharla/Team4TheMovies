using System;

public abstract class Repository
{
    public string repoDest = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName;
    public string FullPath { get { return Path.Combine(repoDest, RepoName); } }
    public abstract string RepoName { get; set; }
    public ObservableCollection<object> repoList = new ObservableCollection<object>();

    public void CreateRepository()
    {
        //Er i tvivl om hvor filen skal ligge
        StreamWriter sw = new StreamWriter(FullPath);
        sw.Close();
    }
}

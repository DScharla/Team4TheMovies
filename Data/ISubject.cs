using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using TheMoviesNy.ViewModel;

namespace TheMoviesNy.Data
{
    public abstract class ISubject
    {
        public List<IObserver> observers = new List<IObserver>();

        public void Attach(IObserver o) { observers.Add(o); }
        public void Detach(IObserver o) { observers.Remove(o); }
        public abstract void Notify();
    }

}

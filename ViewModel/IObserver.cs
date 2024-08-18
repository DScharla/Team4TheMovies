using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace TheMoviesNy.ViewModel
{
    public interface IObserver
    {
        void Update(ObservableCollection<object> repoList);
    }
}

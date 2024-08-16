
using System.Windows.Input;

namespace TheMoviesNy.ViewModel
{
    public class RelayCommand : ICommand
    {
        private Action<object> execute; //Bruges til at sige "Dette kan altid eksekveres", da denne ikke returnere en værdi
        private Func<object, bool> canExecute; //Bruges til at sige, kan kun eksekveres hvis...", da denne returnere en værdi.

        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove {  CommandManager.RequerySuggested -= value;}
        }

        public bool CanExecute(object? parameter)
        {
            return canExecute == null || canExecute(parameter); //Hvis canExecute ikke får en funktion kan den eksekvere ELLER hvis den får en funktion. lader vi canExecute om at vurdere hvorvidt der kan eksekveres
        }

        public void Execute(object? parameter)
        {
            execute(parameter);
        }
        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null) 
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }
    }
}

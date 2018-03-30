using System;
using System.Windows.Input;

namespace Teplo.Command
{
    public class RelayCommand : ICommand
    {
        private Action<object> execute;
        private Func<object, bool> canExecute;
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return this.canExecute == null || this.canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            this.execute(parameter);
        }

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            this.execute = execute ?? throw new ArgumentNullException(nameof(execute));
            //if(execute==null)
            //{
            //    throw new ArgumentNullException(nameof(execute));
            //}
            this.execute = execute;
            this.canExecute = canExecute;
        }
        public RelayCommand(Action<object> execute) : this(execute, null)
        { }
    }
}

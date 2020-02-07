using System;

namespace EasyToDo.Commands
{
    public class GeneralCommand<T> : Command
    {
        private readonly Action<T> _execute;
        private readonly Predicate<T> _canExecute;
        
        public GeneralCommand(Action<T> execute, Predicate<T> canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
        }
        
        private bool CanExecute(T parameter)
        {
            return _canExecute?.Invoke(parameter) ?? true;
        }

        private void Execute(T parameter)
        {
            _execute?.Invoke(parameter);
        }
        
        protected override void Execute(object parameter)
        {
            Execute((T)parameter);
        }

        protected override bool CanExecute(object parameter)
        {
            return parameter is T && CanExecute((T)parameter);
        }
    }
}
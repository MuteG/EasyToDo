using System;
using System.Windows.Input;

namespace EasyToDo.Commands
{
    public abstract class Command : ICommand
    {
        /// <summary>コマンドを実行するかどうかに影響するような変更があった場合に発生します。</summary>
        public event EventHandler CanExecuteChanged;
        
        void ICommand.Execute(object parameter)
        {
            Execute(parameter);
        }

        bool ICommand.CanExecute(object parameter)
        {
            return CanExecute(parameter);
        }

        protected abstract void Execute(object parameter);
        protected abstract bool CanExecute(object parameter);
    }
}
using MES_OpcUa.ViewModel;
using Opc.UaFx;
using Opc.UaFx.Client;
using System;
using System.Windows.Input;

namespace MES_OpcUa.Components
{
    public abstract class Command : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public abstract bool CanExecute(object? parameter);

        public abstract void Execute(object parameter);
    }
}

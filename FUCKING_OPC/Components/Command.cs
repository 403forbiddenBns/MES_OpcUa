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

        public abstract void Execute(object parameter);
        public abstract bool CanExecute(object? parameter);
    }

    public class ConnectCommand : Command
    {
        private readonly MainViewModel _mainViewModel;
        private readonly ClientStore _clientStore;

        public ConnectCommand(MainViewModel mainViewModel, ClientStore clientStore)
        {
            _mainViewModel = mainViewModel;
            _clientStore = clientStore;
        }

        public override bool CanExecute(object? parameter) => true; //TODO: IMPLEMENT ALL STUFF THAT NEEDED FOR CHECK ADDRESS

        public override void Execute(object parameter)
        {
            OpcClient client = new OpcClient(_mainViewModel.Address, new OpcSecurityPolicy(OpcSecurityMode.None));
            _clientStore.CreateClient(client);
        }
    }
}

using MES_OpcUa.Components;
using MES_OpcUa.Model;
using Opc.UaFx.Client;
using System.Windows;
using System.Windows.Input;

namespace MES_OpcUa.ViewModel
{
    public partial class BrowserViewModel : BaseViewModel
    {
        private BrowserModel _browserModel;
        public ICommand CloseApplicationCommand { get; }
        private bool CanCloseApplicationCommandExecute(object p) => true;
        private void OnCloseApplicationCommandExecuted(object p)
        {
            _browserModel.OpcClient?.Disconnect();
            Application.Current.Shutdown();
        }

        public BrowserViewModel(OpcClient client)
        {
            CloseApplicationCommand = new LambaCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute);
            _browserModel = new BrowserModel(client);
        }
    }
}

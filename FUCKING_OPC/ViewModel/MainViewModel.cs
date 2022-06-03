using MES_OpcUa.Components;
using Opc.UaFx.Client;
using System.Windows;
using System.Windows.Input;

namespace MES_OpcUa.ViewModel
{
    public partial class MainViewModel : BaseViewModel
    {
        #region Fields

        private string _address = "opc.tcp://172.24.182.20:45500"; //"opc.tcp://DESKTOP-4LC5DK7:53530"
        private OpcClient _client;

        #endregion

        #region Props

        public string Address
        {
            get => _address;
            set => Set(ref _address, value);
        }

        public OpcClient Client { get; set; }

        #endregion


        #region ctor

        public MainViewModel()
        {
            CloseApplicationCommand = new LambaCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute);
            ConnectToServer = new ConnectCommand(this);
        }

        public void OnClientCreated(OpcClient client)
        {
            _client = client;
        }

        #endregion


        #region Commands

        #region CloseApp

        public ICommand CloseApplicationCommand { get; }
        private bool CanCloseApplicationCommandExecute(object p) => true;
        private void OnCloseApplicationCommandExecuted(object p)
        {
            _client?.Disconnect();
            Application.Current.Shutdown();
        }

        #endregion

        #region Connect

        public ConnectCommand ConnectToServer { get; }

        #endregion

        #endregion
    }
}

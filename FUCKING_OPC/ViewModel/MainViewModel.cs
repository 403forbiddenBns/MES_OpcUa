using MES_OpcUa.Components;
using MES_OpcUa.Model;
using MES_OpcUa.View;
using System.Windows;
using System.Windows.Input;

namespace MES_OpcUa.ViewModel
{
    public partial class MainViewModel : BaseViewModel
    {

        #region Fields

        private string _address = "opc.tcp://DESKTOP-4LC5DK7:53530";
        private MainModel _mainModel;

        #endregion

        #region Props

        public string Address
        {
            get => _address;
            set => Set(ref _address, value);
        }

        #endregion

        #region Commands

        #region CloseApp
        public ICommand CloseApplicationCommand { get; }
        private bool CanCloseApplicationCommandExecute(object p) => true;
        private void OnCloseApplicationCommandExecuted(object p)
        {
            _mainModel?.BrowserModel?.OpcClient?.Disconnect();
            Application.Current.Shutdown();
        }
        #endregion

        #region Connect

        public ICommand ConnectToServer { get; }
        private bool CanConnectToServerExecute(object p) => true;
        private void OnConnectToServerExecuted(object p)
        {
            Address = (string)p;
            _mainModel = new(Address);

            BrowserViewModel browserVM = new BrowserViewModel(_mainModel.BrowserModel.OpcClient);
            BrowserView browserView = new BrowserView();
            browserView.Open(browserVM);
            //DEBUG: show connection status
            //MessageBox.Show(_mainModel.OpcClient.State.ToString(), "Connection status", 0, MessageBoxImage.Information);
        }

        #endregion


        #endregion

        #region ctor

        public MainViewModel()
        {
            //TODO: HERE!
            CloseApplicationCommand = new LambaCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute);
            ConnectToServer = new LambaCommand(OnConnectToServerExecuted, CanConnectToServerExecute);
        }

        #endregion

        #region Methods

        //Todo: Implement check address later
        public bool ValidateURI()
        {
            if (!(Address.Contains("opc://") && Address.Contains(':')))
                return false;
            return true;
        }

        #endregion
    }
}

using MES_OpcUa.Components;
using MES_OpcUa.Model;
using Opc.UaFx.Client;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MES_OpcUa.ViewModel
{
    public partial class BrowserViewModel : BaseViewModel
    {
        #region vars

        private BrowserModel _browserModel;
        private ClientStore _clientStore;

        private TreeView _browserTreeView;
        
        private OpcClient _client;
        public ICommand CloseApplicationCommand { get; }
        #endregion

        #region props

        readonly TreeViewItem _currentNode;
        public TreeView BrowserTreeView
        {
            get { return _browserTreeView; }
            set
            {
                _browserTreeView = value;
                //PropertyChnaged implement
            }
        }

        public OpcClient Client
        {
            get { return _client; }
            set { _client = value; }
        }

        #endregion

        #region meths

        private bool CanCloseApplicationCommandExecute(object p) => true;
        private void OnCloseApplicationCommandExecuted(object p)
        {
            _browserModel?.Client?.Disconnect();
            Application.Current.Shutdown();
        }

        #endregion

        #region ctor

        public BrowserViewModel(ClientStore clientStore, OpcClient client)
        {
            _clientStore = clientStore;
            Client = client;
            CloseApplicationCommand = new LambaCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute);
            _browserModel = new BrowserModel(client);

            //Nodes = new ObservableCollection<OpcNodeInfo>();
            //Nodes.Add(client.BrowseNode("i=84"));
        }

        #endregion

    }
}

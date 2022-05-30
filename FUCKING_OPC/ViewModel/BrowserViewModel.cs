using MES_OpcUa.Components;
using MES_OpcUa.Model;
using Opc.UaFx.Client;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MES_OpcUa.ViewModel
{
    public partial class BrowserViewModel : BaseViewModel
    {
        #region vars

        private BrowserModel _browserModel;
        private TreeView _browserTreeView;
        private ClientStore _clientStore;

        #endregion

        #region props

        TreeViewItem _currentNode;
        public TreeView BrowserTreeView
        {
            get { return _browserTreeView; }
            set 
            { 
                _browserTreeView = value; 
                //PropertyChnaged implement
            }
        }

        public ICommand CloseApplicationCommand { get; }


        #endregion

        #region meths

        private bool CanCloseApplicationCommandExecute(object p) => true;
        private void OnCloseApplicationCommandExecuted(object p)
        {
            _browserModel.OpcClient?.Disconnect();
            Application.Current.Shutdown();
        }


        #endregion

        #region ctor

        public BrowserViewModel(ClientStore clientStore)
        {
            _clientStore = clientStore;
            CloseApplicationCommand = new LambaCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute);
            _browserModel = new BrowserModel(clientStore); //TODO: HOW TO GET CLIENT OUT THERE?????
            //Nodes = new ObservableCollection<OpcNodeInfo>();
            //Nodes.Add(client.BrowseNode("i=84"));
        }

        #endregion

    }
}

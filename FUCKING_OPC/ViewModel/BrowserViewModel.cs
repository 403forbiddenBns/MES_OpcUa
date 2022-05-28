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
        private ObservableCollection<OpcNodeInfo> _nodes;

        #endregion

        #region props
        public TreeView BrowserTreeView
        {
            get { return _browserTreeView; }
            set 
            { 
                _browserTreeView = value; 
                //PropertyChnaged implement
            }
        }

        public ObservableCollection<OpcNodeInfo> Nodes
        {
            get
            {
                return _nodes;
            }
            set
            {
                _nodes = value;
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
            _nodes = new ObservableCollection<OpcNodeInfo>();

        }

        private void FillTree(OpcClient client)
        {
            _browserTreeView = new TreeView();
            _browserTreeView.Name = _browserModel.OpcClient?.BrowseNode("i=84").Name.Value;
        }

        #endregion

        #region ctor
        public BrowserViewModel(OpcClient client)
        {
            CloseApplicationCommand = new LambaCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute);
            _browserModel = new BrowserModel(client);
            
            Nodes = new ObservableCollection<OpcNodeInfo>();
            Nodes.Add(client.BrowseNode("i=84"));
        }

        #endregion

    }
}

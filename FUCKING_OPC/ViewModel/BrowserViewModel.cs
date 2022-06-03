using MES_OpcUa.Components;
using MES_OpcUa.Model;
using Opc.UaFx.Client;
using System;
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
        private OpcClient _client;
        private readonly OpcNodeInfo _rootNode;

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

        public BrowserViewModel(OpcClient client)
        {
            if (client == null)
                throw new NullReferenceException(nameof(client));
            Client = client;
            _browserModel = new BrowserModel(client);
            _browserTreeView = new TreeView();
            CloseApplicationCommand = new LambaCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute);
            _rootNode = client.BrowseNode("i=84");
            
            //Nodes = new ObservableCollection<OpcNodeInfo>();
            //Nodes.Add(client.BrowseNode("i=84"));
        }

        private void FillTreeWithOpcNodes(TreeView tree, OpcClient client)
        {
            tree.Items.Add(_rootNode); //HOW TO ADD VIEW MODELS IN TREE? SHOULD I DO THAT? WATCH SEAN ADD SOMTHING LIKE THAT
        }

        #endregion

    }
}

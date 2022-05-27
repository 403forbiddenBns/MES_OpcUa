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

        public void FillNodeList(OpcNodeInfo node, int level = 0)
        {
            OpcNodeInfo rootNode = _browserModel.OpcClient.BrowseNode("i=84").Children();

            _browserModel.Nodes.Add(rootNode);


            foreach (var item in rootNode)
            {
            }

            //var value = node.Attribute(OpcAttribute.DisplayName).Value;

            //if (level == 0)
            //Console.WriteLine($"_{level}{pattern}{value}{node.NodeId}");


            //foreach (var childNode in node.Children())
            //Browse(childNode, level);
        }
    }
}

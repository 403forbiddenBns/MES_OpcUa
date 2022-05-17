using Opc.UaFx.Client;
using Prism.Mvvm;
using System.Collections.ObjectModel;

namespace MES_OpcUA.Model
{
    public class BrowserModel : BindableBase
    {
        OpcClient _client;
        ObservableCollection<OpcNodeInfo> _nodes; //TODO: Implement IPropertyChanger for this collection.

        public OpcClient Client { get; set; }

        public BrowserModel(string address)
        {
            Client = new OpcClient(address);
        }

        public ObservableCollection<OpcNodeInfo> Nodes 
        { 
            get 
            { 
                return _nodes;
            } 
        }
    }
}

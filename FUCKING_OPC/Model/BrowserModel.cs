using Opc.UaFx.Client;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MES_OpcUa.Model
{
    public class BrowserModel
    {
        private OpcClient _opcClient;
        private ObservableCollection<OpcNodeInfo> _nodes;

        public OpcClient OpcClient
        {
            get { return _opcClient; }
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

        public BrowserModel(OpcClient client)
        {
            _opcClient = client;
            _nodes = new ObservableCollection<OpcNodeInfo>();
        }
    }
}

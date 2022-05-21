using Opc.UaFx.Client;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_OpcUa.Model
{
    public class BrowserModel
    {
        private OpcClient _opcClient;
        private ObservableCollection<OpcNodeInfo> _nodes; //TODO: NE FAKT BLYAT CHTO OpcNodeInfo

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

        public BrowserModel(OpcClient opcClient)
        {
            _opcClient = opcClient;
            _nodes = new ObservableCollection<OpcNodeInfo>();
        }
    }
}

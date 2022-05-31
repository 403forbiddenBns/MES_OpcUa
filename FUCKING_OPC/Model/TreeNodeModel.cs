using MES_OpcUa.TreeElements;
using MES_OpcUa.ViewModel;
using Opc.UaFx.Client;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_OpcUa.Model
{
    public class TreeNodeModel : BaseViewModel
    {
        public string Name { get; set; }
        public OpcNodeInfo RootNodeInfo { get; set; }

        public TreeNodeModel(OpcNodeInfo node)
        {
            RootNodeInfo = node;
            Name = RootNodeInfo.Name.Value; //TODO: Need to check;
        }
    }
}

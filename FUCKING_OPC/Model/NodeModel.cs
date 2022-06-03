using MES_OpcUa.ViewModel;
using Opc.UaFx.Client;

namespace MES_OpcUa.Model
{
    public class NodeModel : BaseViewModel
    {
        public string Name { get; set; }
        public OpcNodeInfo RootNodeInfo { get; set; }

        public NodeModel(OpcNodeInfo node)
        {
            RootNodeInfo = node;
            Name = "NOT_INITIALIZED";
            if (node != null)
            Name = RootNodeInfo.Name.Value; //TODO: Need to check;
        }
    }
}

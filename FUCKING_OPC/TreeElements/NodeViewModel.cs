using MES_OpcUa.ViewModel;
using Opc.UaFx.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_OpcUa.TreeElements
{
    public class NodeViewModel : BaseViewModel
    {
        //TODO: MESSAGE BUS TO DELIVER THE CLIENT INSTANSE CUS WITHOUT HIM I CANT INITIALIZE TREE
        //TODO: Try to find implement of tree :(
        //TODO: Find the way to bind it (depends on how i deliver the client instance)
        TreeNodeItem _rootNode;

        public NodeViewModel()
        {
            //_rootNode = new TreeNodeItem();
        }
    }
}

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
        string _name;
        TreeNodeItem _rootNodeItem;
        OpcNodeInfo _rootNodeInfo;

        OpcNodeInfo OpcNodeInfo
        {
            get
            {
                return _rootNodeInfo;
            }
        }

        public string Name 
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(_name));
            } 
        }

        public NodeViewModel()
        {
            //_rootNodeInfo = ____GET FROM CLIENT___
            _rootNodeItem = new TreeNodeItem(_rootNodeInfo);
            //_rootNode = new TreeNodeItem();
        }
    }
}

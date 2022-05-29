using Opc.UaFx;
using Opc.UaFx.Client;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_OpcUa.TreeElements
{
    public class TreeNodeItem
    {
        public string Name { get; set; }
    
        public string Id { get; set; }

        public static OpcNodeInfo CurrentNode { get; private set; }

        public ObservableCollection<TreeNodeItem> ChildNodes { get; private set; }

        public TreeNodeItem(OpcNodeInfo node)
        {
            CurrentNode = node;
            Name = node.Name.Value;
            ChildNodes = GetChilds();
            Id = node.NodeId.ValueAsString;
        }

        public static ObservableCollection<TreeNodeItem> GetChilds()
        {
            ObservableCollection<TreeNodeItem> result = new ObservableCollection<TreeNodeItem>();
            var childs = CurrentNode.Children();
            foreach (var item in childs)
            {
                result.Add(new TreeNodeItem(item));
            }
            return result;
        }
    }
}

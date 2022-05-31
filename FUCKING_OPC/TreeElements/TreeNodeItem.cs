using MES_OpcUa.ViewModel;
using Opc.UaFx.Client;
using System.Collections.ObjectModel;

namespace MES_OpcUa.TreeElements
{
    public class TreeNodeItem : BaseViewModel
    {
        private string _name;
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
        public static OpcNodeInfo CurrentNode { get; private set; }
        public ObservableCollection<TreeNodeItem> ChildNodes { get; private set; }

        public TreeNodeItem(OpcNodeInfo node)
        {
            CurrentNode = node;
            //TODO: BOTTOM LINE NOT WORKING! NEED TO FIX
            //Name = node.Name.Value;
            ChildNodes = GetChilds();
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

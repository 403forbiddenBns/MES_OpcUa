using MES_OpcUa.ViewModel;
using Opc.UaFx.Client;
using System.Collections.ObjectModel;

namespace MES_OpcUa.TreeElements
{
    public class TreeNodeViewModel : BaseViewModel
    {
        private string _name;
        private OpcNodeInfo _currentNode;
        private ObservableCollection<TreeNodeViewModel> _childNodes;
        public ObservableCollection<TreeNodeViewModel> ChildNodes
        { 
            get 
            { 
                return _childNodes; 
            }
            set 
            { 
                if(_childNodes != value)
                {
                    _childNodes = value;
                    RaisePropertyChanged(() => _childNodes);
                }
            }
        }

        public string Name 
        {
            get
            {
                return _name;
            }
            set { _name = value; RaisePropertyChanged(() => _name); }
        }
        public OpcNodeInfo CurrentNode 
        {
            get { return _currentNode; } 
            set { Set(ref _currentNode, value); } //TODO: IS IT EVEN WORKS?
        }

        public TreeNodeViewModel(OpcNodeInfo node)
        {
            _currentNode = node;
            Name = node.DisplayName;
            //TODO: BOTTOM LINE NOT WORKING! NEED TO FIX
            //Name = node.Name.Value;
            ChildNodes = new ObservableCollection<TreeNodeViewModel>();
        }

        //public static ObservableCollection<TreeNodeViewModel> GetChilds()
        //{
        //    ObservableCollection<TreeNodeViewModel> result = _currentNode.Children();
        //    foreach (var item in result)
        //    {
        //        result.Add(item);
        //    }
        //    return result;
        //}
    }
}

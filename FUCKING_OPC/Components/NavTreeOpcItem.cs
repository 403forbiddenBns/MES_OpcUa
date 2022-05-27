using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace MES_OpcUa.Components
{
    public abstract class NavTreeOpcItem : INavTreeOpcItem
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected BitmapSource myIcon;
        public BitmapSource MyIcon
        {
            get { return myIcon; }
            set { myIcon = value; }
        }

        protected ObservableCollection<INavTreeOpcItem> children;
        public ObservableCollection<INavTreeOpcItem> Children 
        { 
            get 
            {
                return children ?? (children = GetMyChildren()); 
            }
            set
            {
                SetProperty(ref isExpanded, value, "IsExpanded");
            }
        }

        public string FriendlyName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string NodeName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsExpanded { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IncludeOpcVariable { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void DeleteChildren()
        {
            throw new NotImplementedException();
        }
    }
}

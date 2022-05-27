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
    public interface INavTreeOpcItem : INotifyPropertyChanged
    {
        string FriendlyName { get; set; }
        BitmapSource MyIcon { get; set; }
        string NodeName { get; set; }

        ObservableCollection<INavTreeOpcItem> Children { get; }

        bool IsExpanded { get; set; }
        bool IncludeOpcVariable { get; set; }
        void DeleteChildren();
    }
}

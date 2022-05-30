using MES_OpcUa.ViewModel;
using System.Windows;

namespace MES_OpcUa.View
{
    /// <summary>
    /// Interaction logic for BrowserView.xaml
    /// </summary>
    public partial class BrowserView : Window, IView
    {
        public BrowserView()
        {
            InitializeComponent();
        }

        public bool? Open(BrowserViewModel vmInstance)
        {
            DataContext = vmInstance;
            return this.ShowDialog();
        }
    }
}

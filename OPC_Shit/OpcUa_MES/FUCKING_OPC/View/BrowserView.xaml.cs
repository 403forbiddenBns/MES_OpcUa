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

        public bool? Open(BrowserViewModel browserViewModel)
        {
            DataContext = browserViewModel;
            return this.ShowDialog();
        }
    }

    interface IView
    {
        bool? Open(BrowserViewModel browserVM);
    }
}

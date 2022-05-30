using MES_OpcUa.Components;
using MES_OpcUa.ViewModel;
using System.Windows;

namespace MES_OpcUa
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            ClientStore clientStore = new ClientStore();
            MainViewModel mvm = new MainViewModel(clientStore);
        }
    }
}

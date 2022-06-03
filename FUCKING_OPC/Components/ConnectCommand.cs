using MES_OpcUa.View;
using MES_OpcUa.ViewModel;
using Opc.UaFx;
using Opc.UaFx.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_OpcUa.Components
{
    public class ConnectCommand : Command
    {
        private readonly MainViewModel _mainViewModel;

        public ConnectCommand(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
        }

        public override bool CanExecute(object? parameter) => true;

        public override void Execute(object parameter)
        {
            OpcClient client = new OpcClient(_mainViewModel.Address, new OpcSecurityPolicy(OpcSecurityMode.None));
            BrowserViewModel browserVM = new BrowserViewModel(_mainViewModel.Client);
            BrowserView browserView = new BrowserView();
            browserView.Open(browserVM);
            //DEBUG: show connection status
            //MessageBox.Show(_mainModel.OpcClient.State.ToString(), "Connection status", 0, MessageBoxImage.Information);
        }

        //TODO: Delete bottom line
        //public override bool CanExecute(object? parameter) => true; //TODO: IMPLEMENT ALL STUFF THAT NEEDED FOR CHECK ADDRESS
    }
}

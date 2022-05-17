using MES_OpcUA.Model;
using Opc.UaFx.Client;
using Prism.Mvvm;
using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MES_OpcUA.ViewModel
{
    public class MainViewModel : BindableBase
    {
        private string _address;

        //TODO: MAKE MY COMMAND AND TRY TO LAUNCH
        public ICommand btnExit { get; set; }
        public ICommand btnConnect { get; set; }

        

        public string Address
        {
            get { return _address; }
            set 
            {
                _address = value;
                RaisePropertyChanged(_address);
            }
        }

        public MainViewModel()
        {
            Address = "123";
        }

        public bool ValidateURI()
        {
            if (!(Address.Contains("opc://") && Address.Contains(':')))
                return false;
            return true;
        }

        //MessageBox.Show("Wrong address!", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
    }
}

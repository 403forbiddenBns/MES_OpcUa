using MES_OpcUA.Model;
using Opc.UaFx.Client;
using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MES_OpcUA.ViewModel
{
    public class MainViewModel : ViewModel
    {
        private string _address = "Enter the address...";

        //TODO: MAKE MY COMMAND AND TRY TO LAUNCH
        public ICommand btnExit { get; set; }


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
            //CHECK ADDRESS PROPERTY
        }

        public bool ValidateURI()
        {
            if (!(Address.Contains("opc://") && Address.Contains(':')))
                return false;
            return true;
        }


        public void btnConnect(string addr)
        {
            //if (ValidateURI())
            //{
            MessageBox.Show("Wrong address!", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            //return;
            //}
        }
    }
}

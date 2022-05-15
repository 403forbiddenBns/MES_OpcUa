using MES_OpcUA.Model;
using Opc.UaFx.Client;
using System;
using System.Windows;
using System.Windows.Controls;

namespace MES_OpcUA.ViewModel
{
    public class MainViewModel : ViewModel
    {
        private MainModel mainModel;

        private string _address;

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public OpcClient OpcClient
        {
            get { return opcClient; }
            set { opcClient = value; }
        }

        public MainViewModel()
        {
            switch (ValidateURI())
            {
                case true:
                    mainModel = new MainModel(Address);
                    //todo: SOMEHOW SWITCH CONTEXT TO BROWSER WHEN INIT
                    //todo: INIT BROWSER
                    break;
                case false:
                    var lb = new Label();
                    MessageBox.Show("Wrong address!", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
            }
            Environment.Exit(0);
        }

        public bool ValidateURI()
        {
           return ((Address.Contains("opc://") && Address.Contains(':')));
        }
    }
}

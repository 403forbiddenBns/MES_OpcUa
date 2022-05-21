using Prism.Mvvm;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using FUCKING_OPC.ViewModel;
using System;
using System.Windows;
using System.Windows.Input;
using FUCKING_OPC.Components;

namespace MES_OpcUA.ViewModel
{
    public partial class MainViewModel : BaseViewModel
    {

        #region Fields
        
        private string _address;
        
        #endregion
        
        #region Props

        public string Address
            {
                get => _address;
                set => Set(ref _address, value);
            }

        #endregion

        #region Commands

        public ICommand CloseApplicationCommand { get; }

        private bool CanCloseApplicationCommandExecute(object p) => true;

        private void OnCloseApplicationCommandExecuted(object p)
        {
            Application.Current.Shutdown();
        }
        
        #endregion


        #region ctor

        public MainViewModel()
        {
            #region CloseApp
            //TODO: HERE!
            CloseApplicationCommand = new LambaCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute);
            #endregion


        }

        #endregion

        #region Methods

        public bool ValidateURI()
        {
            if (!(Address.Contains("opc://") && Address.Contains(':')))
                return false;
            return true;
        }

        #endregion
        //MessageBox.Show("Wrong address!", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
    }
}

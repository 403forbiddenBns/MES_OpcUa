using MES_OpcUA.ViewModel;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MES_OpcUA
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainView : Window
    {
        
        public MainView()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }
    }
}

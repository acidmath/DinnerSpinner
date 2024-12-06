using DinnerSpinner.Data;
using DinnerSpinner.UI.ViewModel;
using Microsoft.EntityFrameworkCore;
using System.Windows;

namespace DinnerSpinner {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(MainViewModel mainViewModel)
        {
            InitializeComponent();
            DataContext = mainViewModel;            
        }
    }
}
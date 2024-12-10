using DinnerSpinner.UI.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace DinnerSpinner.UI.Element {
    
    public partial class SpinnerElement : UserControl
    {
        public SpinnerElement()
        {            
            InitializeComponent();
            DataContext = new SpinnerViewModel();
        }
    }
}

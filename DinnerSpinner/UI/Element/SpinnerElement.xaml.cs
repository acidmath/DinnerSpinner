using DinnerSpinner.UI.ViewModel;
using System.Windows.Controls;

namespace DinnerSpinner.UI.Element {
    
    public partial class SpinnerElement : UserControl
    {
        public SpinnerElement()
        {
            DataContext = new SpinnerViewModel();
            InitializeComponent();
            
        }
    }
}

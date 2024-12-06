using DinnerSpinner.UI.ViewModel;
using System.Windows.Controls;

namespace DinnerSpinner.UI.Element {
    
    public partial class AddRestaurantElement : UserControl {
        public AddRestaurantElement() {
            InitializeComponent();
            DataContext = new AddRestaurantViewModel();
        }
    }
}

using DinnerSpinner.UI.ViewModel;
using System.Windows.Controls;

namespace DinnerSpinner.UI.Element {

    public partial class AddHumanElement : UserControl {
        public AddHumanElement() {
            InitializeComponent();
            DataContext = new AddHumanViewModel();
        }
    }
}

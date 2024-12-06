using CommunityToolkit.Mvvm.Input;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace DinnerSpinner.UI.Element {

    public partial class AddRestaurantElement : UserControl {

        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register(
            "Text",
            typeof(string),
            typeof(UserControl));

        public string? Text{
            get {
                return (string?)GetValue(TextProperty);
            }

            set {
                SetValue(TextProperty, value);
            }
        }

        public static readonly DependencyProperty CommandProperty =
            DependencyProperty.Register(
            "Command",
            typeof(IRelayCommand),
            typeof(UserControl));

        public IRelayCommand Command {
            get {
                return (IRelayCommand)GetValue(CommandProperty);
            }

            set {
                SetValue(CommandProperty, value);
            }
        }

        public AddRestaurantElement() {
            InitializeComponent();
        }
    }
}

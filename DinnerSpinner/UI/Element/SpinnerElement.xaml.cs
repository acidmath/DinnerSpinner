using DinnerSpinner.UI.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace DinnerSpinner.UI.Element {
    
    public partial class SpinnerElement : UserControl
    {
        public static readonly DependencyProperty CanvasWidthProperty =
            DependencyProperty.Register("CanvasWidth", typeof(double), typeof(SpinnerElement), new PropertyMetadata(default(double)));

        public double CanvasWidth {
            get { return (double)GetValue(CanvasWidthProperty); }
            set { SetValue(CanvasWidthProperty, value); }
        }

        public static readonly DependencyProperty CanvasHeightProperty =
            DependencyProperty.Register("CanvasHeight", typeof(double), typeof(SpinnerElement), new PropertyMetadata(default(double)));

        public double CanvasHeight {
            get { return (double)GetValue(CanvasHeightProperty); }
            set { SetValue(CanvasHeightProperty, value); }
        }

        public SpinnerElement()
        {            
            InitializeComponent();
            DataContext = this;
        }
    }
}

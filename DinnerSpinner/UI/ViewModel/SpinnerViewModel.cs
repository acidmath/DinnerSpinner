using System.Windows;

namespace DinnerSpinner.UI.ViewModel {
    public class SpinnerViewModel : DependencyObject {

        public static readonly DependencyProperty WidthProperty =
            DependencyProperty.Register("Width", typeof(double), typeof(SpinnerViewModel), new PropertyMetadata(default(double)));

        public double Width {
            get { return (double)GetValue(WidthProperty); }
            set { SetValue(WidthProperty, value); }
        }

        public static readonly DependencyProperty HeightProperty =
            DependencyProperty.Register("Height", typeof(double), typeof(SpinnerViewModel), new PropertyMetadata(default(double)));

        public double Height {
            get { return (double)GetValue(HeightProperty); }
            set { SetValue(HeightProperty, value); }
        }

        public SpinnerViewModel() {

            var balls = (Height, Width);
            ;
        }

    }
}

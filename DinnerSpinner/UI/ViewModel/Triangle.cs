using System.Windows.Media;

namespace DinnerSpinner.UI.ViewModel {
    public class Triangle {

        public PointCollection Points { get; set; }

        public Triangle(PointCollection points) {
            Points = points;
        }
    }
}

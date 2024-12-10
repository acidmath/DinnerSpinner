using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Media;

namespace DinnerSpinner.UI.ViewModel {
    public class SpinnerViewModel {

        public ObservableCollection<Triangle> Triangles { get; set; } = new();

        public SpinnerViewModel() {

            Point point1 = new Point(100, 100);
            Point point2 = new Point(100, 0);
            Point point3 = new Point(0, 0);
            PointCollection points = new PointCollection();
            points.Add(point1);
            points.Add(point2);
            points.Add(point3);

            Triangles.Add(new Triangle(points));
        }

    }
}

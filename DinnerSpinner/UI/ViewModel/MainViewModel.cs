using DinnerSpinner.Data;
using Microsoft.EntityFrameworkCore;

namespace DinnerSpinner.UI.ViewModel {
    public class MainViewModel {

        private int _humanCount;
        public string HumanText => $"Humans: {_humanCount}";

        private int _restaurantCount;
        public string RestaurantText => $"Restaurants: {_restaurantCount}";

        public MainViewModel() {
            DbContextOptionsBuilder<DinnerSpinnerContext> optionsBuilder = new();
            optionsBuilder.UseSqlite("Data Source=dinnerSpinner.db");
            DinnerSpinnerContext context = new(optionsBuilder.Options);
            _humanCount = context.Humans.Count();
            _restaurantCount = context.Restaurants.Count();
        }
    }
}

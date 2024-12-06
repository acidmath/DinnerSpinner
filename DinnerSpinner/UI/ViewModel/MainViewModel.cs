using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DinnerSpinner.Data;
using DinnerSpinner.Data.Model;

namespace DinnerSpinner.UI.ViewModel {
    public partial class MainViewModel : ObservableObject {

        private readonly DinnerSpinnerContext _context;

        private int _humanCount;
        public string HumanText => $"Humans: {_humanCount}";

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(RestaurantText))]
        private int _restaurantCount;
        public string RestaurantText => $"Restaurants: {RestaurantCount}";

        [ObservableProperty]
        private string _restaurantName;

        public MainViewModel(DinnerSpinnerContext context) {
            _context = context;
            _humanCount = context.Humans.Count();
            _restaurantCount = context.Restaurants.Count();
        }

        [RelayCommand]
        private async Task AddRestaurantAsync() {

            Restaurant restaurant = new() {
                Name = RestaurantName
            };

            _context.Restaurants.Add(restaurant);
            await _context.SaveChangesAsync();
        }
    }
}

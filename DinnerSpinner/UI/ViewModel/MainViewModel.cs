using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DinnerSpinner.Data;
using DinnerSpinner.Data.Model;
using Microsoft.EntityFrameworkCore;

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

        [ObservableProperty]
        private List<Restaurant> _restaurants;

        public MainViewModel(DinnerSpinnerContext context) {
            _context = context;            
        }

        [RelayCommand]
        private async Task LoadAsync() {
            _humanCount = _context.Humans.Count();
            
            Restaurants = await _context.Restaurants.ToListAsync();
            RestaurantCount = Restaurants.Count;
        }

        [RelayCommand]
        private async Task AddRestaurantAsync() {

            Restaurant restaurant = new() {
                Name = RestaurantName
            };

            _context.Restaurants.Add(restaurant);
            await _context.SaveChangesAsync();
            await LoadAsync();
            RestaurantName = string.Empty;
        }
    }
}

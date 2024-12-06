using DinnerSpinner.Data;
using DinnerSpinner.UI.Element;
using DinnerSpinner.UI.ViewModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace DinnerSpinner {
    public partial class App : Application
    {
        public readonly ServiceProvider _serviceProvider;

        public App() {
            IServiceCollection services = new ServiceCollection();
            services.AddDbContextFactory<DinnerSpinnerContext>(options => options.UseSqlite("Data Source=dinnerSpinner.db"));
            services.AddSingleton<MainViewModel>();
            services.AddSingleton<MainWindow>();

            services.AddTransient<AddHumanViewModel>();
            services.AddTransient<AddRestaurantViewModel>();
            services.AddTransient<AddHumanElement>();
            services.AddTransient<AddRestaurantElement>();
            _serviceProvider = services.BuildServiceProvider();
        }

        protected override void OnStartup(StartupEventArgs e) {
            MainWindow mainWindow = _serviceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();

            base.OnStartup(e);
        }
    }
}

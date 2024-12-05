using DinnerSpinner.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Data;
using System.Windows;

namespace DinnerSpinner
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e) {
            ServiceCollection services = new ();
            //services.AddDbContextFactory<DinnerSpinnerContext>(options => options.UseSqlite("Data Source=dinnerSpinner.db"));
            
            //DinnerSpinnerContext context = FancyScaffolder.GetContext();            
            services.BuildServiceProvider();
            base.OnStartup(e);
        }
    }

}

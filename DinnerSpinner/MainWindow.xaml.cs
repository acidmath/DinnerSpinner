using DinnerSpinner.Data;
using Microsoft.EntityFrameworkCore;
using System.Windows;

namespace DinnerSpinner {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DbContextOptionsBuilder<DinnerSpinnerContext> optionsBuilder = new();
            optionsBuilder.UseSqlite("Data Source=dinnerSpinner.db");
            DinnerSpinnerContext context = new(optionsBuilder.Options);
            Console.WriteLine($"how many humans: {context.Humans.Count()}");
        }
    }
}
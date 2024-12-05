using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DinnerSpinner.Data {
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<DinnerSpinnerContext> {
        
        public DinnerSpinnerContext CreateDbContext(string[] args) {
            DbContextOptionsBuilder<DinnerSpinnerContext> optionsBuilder = new();
            optionsBuilder.UseSqlite("Data Source=dinnerSpinner.db");
            return new DinnerSpinnerContext(optionsBuilder.Options);
        }
    }
}

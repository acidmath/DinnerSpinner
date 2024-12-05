using DinnerSpinner.Data.Model;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace DinnerSpinner.Data {

    public class DinnerSpinnerContext : DbContext{

        public DinnerSpinnerContext(DbContextOptions<DinnerSpinnerContext> options) : base(options) {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.ConfigureWarnings(MyWarnings);
            base.OnConfiguring(optionsBuilder);
        }

        private void MyWarnings(WarningsConfigurationBuilder builder) {
            builder.Log(RelationalEventId.PendingModelChangesWarning);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Human>().ToTable(typeof(Human).Name);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Human> Humans { get; set; }

    }

}

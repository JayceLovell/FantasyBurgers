namespace FantasyBurgers.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FantasyBurgerResturantContext : DbContext
    {
        public FantasyBurgerResturantContext()
            : base("name=FantasyBurgerResturantConnectionString")
        {
        }

        public virtual DbSet<Appetizer> Appetizers { get; set; }
        public virtual DbSet<Burger> Burgers { get; set; }
        public virtual DbSet<Dessert> Desserts { get; set; }
        public virtual DbSet<Drink> Drinks { get; set; }
        public virtual DbSet<Side> Sides { get; set; }
        public virtual DbSet<Combo> Combos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appetizer>()
                .Property(e => e.AppetizerPrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Burger>()
                .Property(e => e.BurgerPrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Dessert>()
                .Property(e => e.DessertPrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Drink>()
                .Property(e => e.DrinkPrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Side>()
                .Property(e => e.SidePrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Combo>()
                .Property(e => e.ComboPrice)
                .HasPrecision(10, 2);
        }
    }
}

namespace FantasyBurgers.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FantasyBurgersContext : DbContext
    {
        public FantasyBurgersContext()
            : base("name=FantasyBurgersConnectionString")
        {
        }

        public virtual DbSet<Menu> Menus { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}

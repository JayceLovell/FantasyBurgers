namespace FantasyBurgers.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Burger
    {
        public int BurgerId { get; set; }

        [Required]
        [Display(Name = "Burger")]
        public string BurgerName { get; set; }

        [Required]
        [StringLength(25)]
        [Display(Name = "Description")]
        public string BurgerShortDescription { get; set; }

        [Display(Name = "Description")]
        [ScaffoldColumn(false)]
        public string BurgerLongDescription { get; set; }

        [Display(Name = "Price")]
        [Column(TypeName = "numeric")]
        public decimal BurgerPrice { get; set; }

        [Display(Name = "Display")]
        [ScaffoldColumn(false)]
        public string BurgerImage { get; set; }
    }
}

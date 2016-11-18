namespace FantasyBurgers.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Dessert
    {
        public int DessertId { get; set; }

        [Required]
        public string DessertName { get; set; }

        [Required]
        [StringLength(25)]
        public string DessertShortDescription { get; set; }

        public string DessertLongDescription { get; set; }

        [Column(TypeName = "numeric")]
        public decimal DessertPrice { get; set; }

        public string DessertImage { get; set; }
    }
}

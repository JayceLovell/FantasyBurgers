namespace FantasyBurgers.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Combos")]
    public partial class Combo
    {
        [Key]
        [Column(Order = 0)]
        public int ComboId { get; set; }

        [Key]
        [Column(Order = 1)]
        public string ComboName { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(25)]
        public string ComboShortDescription { get; set; }

        public string ComboLongDescription { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "numeric")]
        public decimal ComboPrice { get; set; }

        public string ComboImage { get; set; }
    }
}

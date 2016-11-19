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
        public int ComboId { get; set; }

        [Required]
        [Display(Name ="Name")]
        public string ComboName { get; set; }

        [Required]
        [StringLength(25)]
        [Display(Name = "Description")]
        public string ComboShortDescription { get; set; }

        [Display(Name ="Detailed Description")]
        [ScaffoldColumn(false)]
        public string ComboLongDescription { get; set; }

        [Required]
        [Column(TypeName = "numeric")]
        [Display(Name ="Price")]
        public decimal ComboPrice { get; set; }

        [Display(Name = "Display")]
        [ScaffoldColumn(false)]
        public string ComboImage { get; set; }
    }
}

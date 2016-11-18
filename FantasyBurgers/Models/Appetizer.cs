namespace FantasyBurgers.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Appetizer
    {
        public int AppetizerId { get; set; }

        [Required]
        [StringLength(50)]
        public string AppetizerName { get; set; }

        [Required]
        [StringLength(50)]
        public string AppetizerShortDescription { get; set; }

        public string AppetizerLongDescription { get; set; }

        [Column(TypeName = "numeric")]
        public decimal AppetizerPrice { get; set; }

        public string AppetizerImage { get; set; }
    }
}

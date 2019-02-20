namespace COMP2084MidtermW2019.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class City
    {
        public int CityId { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "City")]
        public string Name { get; set; }

        [Display(Name = "Year Founded")]
        public int YearFounded { get; set; }

        public int Population { get; set; }

        public int CountryId { get; set; }

        public virtual Country Country { get; set; }
    }
}

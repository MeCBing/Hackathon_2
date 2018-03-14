namespace Oil.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OilTable")]
    public partial class OilTable
    {
        public int Id { get; set; }

        public DateTime RefuelingDate { get; set; }

        [Column("Liter ")]
        public double Liter_ { get; set; }

        public double Kilometer { get; set; }
    }
}

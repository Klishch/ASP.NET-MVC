namespace ObuvkaStore.Models.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OrderProducts
    {
        public int id { get; set; }

        public int idOrder { get; set; }

        public int idProduct { get; set; }

        public int count { get; set; }

        public double? discount { get; set; }

        public double total { get; set; }

        public virtual Orders Orders { get; set; }
    }
}

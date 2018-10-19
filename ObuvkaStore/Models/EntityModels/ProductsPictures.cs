namespace ObuvkaStore.Models.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ProductsPictures
    {
        public int id { get; set; }

        public int idProduct { get; set; }

        [Column(TypeName = "text")]
        public string picture { get; set; }

        public virtual Products Products { get; set; }
    }
}

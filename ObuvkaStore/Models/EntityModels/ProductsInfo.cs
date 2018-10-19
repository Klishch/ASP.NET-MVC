namespace ObuvkaStore.Models.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductsInfo")]
    public partial class ProductsInfo
    {
        public int id { get; set; }

        public int idColor { get; set; }

        public bool availability { get; set; }

        public int idForWhom { get; set; }

        public int idCategory { get; set; }

        public int idProducer { get; set; }

        public int idSeason { get; set; }

        public int idMatherial { get; set; }

        public int idProductDescriptions { get; set; }

        public virtual Categories Categories { get; set; }

        public virtual Colors Colors { get; set; }

        public virtual Seasons Seasons { get; set; }

        public virtual ForWhoms ForWhoms { get; set; }

        public virtual Matherials Matherials { get; set; }

        public virtual Producers Producers { get; set; }

        public virtual Products Products { get; set; }

        public virtual ProductsDescriptions ProductsDescriptions { get; set; }
    }
}

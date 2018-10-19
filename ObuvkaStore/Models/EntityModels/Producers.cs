namespace ObuvkaStore.Models.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Producers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Producers()
        {
            ProductsInfo = new HashSet<ProductsInfo>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string producerName { get; set; }

        [Column(TypeName = "text")]
        public string logo { get; set; }

        [StringLength(50)]
        public string producerCountry { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductsInfo> ProductsInfo { get; set; }
    }
}

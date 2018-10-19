namespace ObuvkaStore.Models.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UsersAddress")]
    public partial class UsersAddress
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UsersAddress()
        {
            Orders = new HashSet<Orders>();
            UsersInfo = new HashSet<UsersInfo>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string country { get; set; }

        [Required]
        [StringLength(50)]
        public string region { get; set; }

        [Required]
        [StringLength(50)]
        public string city { get; set; }

        [Required]
        [StringLength(70)]
        public string street { get; set; }

        public int homeNumb { get; set; }

        public int? flatNumb { get; set; }

        public int zipCode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orders> Orders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsersInfo> UsersInfo { get; set; }
    }
}

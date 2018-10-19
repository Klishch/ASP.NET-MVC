namespace ObuvkaStore.Models.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Orders
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Orders()
        {
            OrderProducts = new HashSet<OrderProducts>();
        }

        public int id { get; set; }

        public int idCustomer { get; set; }

        public DateTime orderDate { get; set; }

        public int idOrderedProducts { get; set; }

        [Required]
        [StringLength(60)]
        public string deliveryCompanyName { get; set; }

        public int deliveryAdress { get; set; }

        [Required]
        [StringLength(100)]
        public string paymentMethod { get; set; }

        [Required]
        [StringLength(70)]
        public string orderStatus { get; set; }

        public virtual Customers Customers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderProducts> OrderProducts { get; set; }

        public virtual UsersAddress UsersAddress { get; set; }
    }
}

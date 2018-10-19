namespace ObuvkaStore.Models.EntityModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UsersInfo")]
    public partial class UsersInfo
    {
        public int id { get; set; }

        [Required]
        [StringLength(20)]
        public string name { get; set; }

        [Required]
        [StringLength(30)]
        public string surname { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string picture { get; set; }

        [StringLength(50)]
        public string userLanguage { get; set; }

        [StringLength(50)]
        public string userStatus { get; set; }

        public int idAdress { get; set; }

        public double discount { get; set; }

        public virtual UsersAddress UsersAddress { get; set; }
    }
}

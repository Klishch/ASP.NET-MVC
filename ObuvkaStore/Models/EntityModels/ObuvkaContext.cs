namespace ObuvkaStore.Models.EntityModels
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ObuvkaContext : DbContext
    {
        public ObuvkaContext()
            : base("name=ObuvkaContext")
        {
        }

        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Colors> Colors { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<ForWhoms> ForWhoms { get; set; }
        public virtual DbSet<Matherials> Matherials { get; set; }
        public virtual DbSet<OrderProducts> OrderProducts { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Producers> Producers { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<ProductsDescriptions> ProductsDescriptions { get; set; }
        public virtual DbSet<ProductsInfo> ProductsInfo { get; set; }
        public virtual DbSet<ProductSizes> ProductSizes { get; set; }
        public virtual DbSet<ProductsPictures> ProductsPictures { get; set; }
        public virtual DbSet<Seasons> Seasons { get; set; }
        public virtual DbSet<UsersAddress> UsersAddress { get; set; }
        public virtual DbSet<UsersInfo> UsersInfo { get; set; }
        public virtual DbSet<UserComments> UserComments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<Categories>()
                .HasMany(e => e.ProductsInfo)
                .WithRequired(e => e.Categories)
                .HasForeignKey(e => e.idCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Colors>()
                .HasMany(e => e.ProductsInfo)
                .WithRequired(e => e.Colors)
                .HasForeignKey(e => e.idColor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customers>()
                .Property(e => e.e_mail)
                .IsUnicode(false);

            modelBuilder.Entity<Customers>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<Customers>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Customers)
                .HasForeignKey(e => e.idCustomer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customers>()
                .HasMany(e => e.UserComments)
                .WithRequired(e => e.Customers)
                .HasForeignKey(e => e.idCustomer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ForWhoms>()
                .HasMany(e => e.ProductsInfo)
                .WithRequired(e => e.ForWhoms)
                .HasForeignKey(e => e.idForWhom)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Matherials>()
                .HasMany(e => e.ProductsInfo)
                .WithRequired(e => e.Matherials)
                .HasForeignKey(e => e.idMatherial)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Orders>()
                .HasMany(e => e.OrderProducts)
                .WithRequired(e => e.Orders)
                .HasForeignKey(e => e.idOrder)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Producers>()
                .Property(e => e.logo)
                .IsUnicode(false);

            modelBuilder.Entity<Producers>()
                .HasMany(e => e.ProductsInfo)
                .WithRequired(e => e.Producers)
                .HasForeignKey(e => e.idProducer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Products>()
                .HasMany(e => e.ProductSizes)
                .WithRequired(e => e.Products)
                .HasForeignKey(e => e.idProduct)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Products>()
                .HasMany(e => e.ProductsPictures)
                .WithRequired(e => e.Products)
                .HasForeignKey(e => e.idProduct)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Products>()
                .HasMany(e => e.UserComments)
                .WithRequired(e => e.Products)
                .HasForeignKey(e => e.idProduct)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductsDescriptions>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<ProductsDescriptions>()
                .HasMany(e => e.ProductsInfo)
                .WithRequired(e => e.ProductsDescriptions)
                .HasForeignKey(e => e.idProductDescriptions)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductsPictures>()
                .Property(e => e.picture)
                .IsUnicode(false);

            modelBuilder.Entity<UsersAddress>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.UsersAddress)
                .HasForeignKey(e => e.deliveryAdress)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UsersAddress>()
                .HasMany(e => e.UsersInfo)
                .WithRequired(e => e.UsersAddress)
                .HasForeignKey(e => e.idAdress)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UsersInfo>()
                .Property(e => e.picture)
                .IsUnicode(false);

            modelBuilder.Entity<UserComments>()
                .Property(e => e.comments)
                .IsUnicode(false);

            modelBuilder.Entity<ProductsInfo>()
                .HasOptional(e => e.Products)
                .WithRequired(e => e.ProductsInfo);

            modelBuilder.Entity<Seasons>()
               .Property(e => e.season)
               .IsUnicode(false);

            modelBuilder.Entity<Seasons>()
                .HasMany(e => e.ProductsInfo)
                .WithRequired(e => e.Seasons)
                .HasForeignKey(e => e.idSeason)
                .WillCascadeOnDelete(false);
        }

        public System.Data.Entity.DbSet<ObuvkaStore.Models.ViewModels.AdminProducts> AdminProducts { get; set; }

        public System.Data.Entity.DbSet<ObuvkaStore.Models.ViewModels.Shoes> Shoes { get; set; }
    }
}

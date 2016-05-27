namespace CompanyData
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using CompanyDomain;
    using CompanyDomain.Entities;

    public partial class CompanyDB : DbContext
    {
        public CompanyDB()
            : base("name=CompanyDB")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(e => e.UnitPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Customer>().Map<Entreprise>(c =>
            {
                c.Requires("IsCompany").HasValue(1);
            });
            modelBuilder.Entity<Customer>().Map<Person>(c =>
            {
                c.Requires("IsCompany").HasValue(0);
            });
            modelBuilder.ComplexType<FullName>()
                .Property(c => c.FirstName).IsOptional();
        }
    }
}

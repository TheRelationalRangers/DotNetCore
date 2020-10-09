using Microsoft.EntityFrameworkCore;
using PizzaMario.EntityConfiguration;
using PizzaMario.Models;

namespace PizzaMario
{
    public class PizzaMarioContext : DbContext
    {
        public PizzaMarioContext(DbContextOptions<PizzaMarioContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Township> Townships { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<DeliveryRange> DeliveryRanges { get; set; }
        public DbSet<OpeningHour> OpeningHours { get; set; }
        public DbSet<AlternateOpeningHour> AlternateOpeningHours { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Sauce> Sauces { get; set; }
        public DbSet<Crust> Crusts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
        public DbSet<ProductCoupon> ProductCoupons { get; set; }
        public DbSet<CategoryCoupon> CategoryCoupons { get; set; }
        public DbSet<ExtraIngredient> ExtraIngredients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AddressConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryCouponConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new OrderLineConfiguration());
            modelBuilder.ApplyConfiguration(new PricingConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ProductCouponConfiguration());
            modelBuilder.ApplyConfiguration(new StoreConfiguration());
            modelBuilder.ApplyConfiguration(new TownshipConfiguration());
        }
    }
}
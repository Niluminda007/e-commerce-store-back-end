using E_Commerce_Store.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Attribute = E_Commerce_Store.Models.Attribute;
using Image = E_Commerce_Store.Models.Image;

namespace E_Commerce_Store.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {

        }
        public DbSet<Attribute> Attributes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems{ get; set; }
        public DbSet<ProductAttribute> ProdcutAttributes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
        public DbSet<OrderItemProductAttribute> OrderItemProductAttributes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<ProductAttribute>()
    .HasKey(pa => pa.Id);


            modelBuilder.Entity<ProductAttribute>()
                .HasOne<Product>(pa => pa.Product)
                .WithMany(p => p.ProductAttributes)
                .HasForeignKey(pa => pa.ProductId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<ProductAttribute>()
                .HasOne<Attribute>(pa => pa.Attribute)
                .WithMany(a => a.ProductAttributes)
                .HasForeignKey(pa => pa.AttributeId)
                .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<Product>()
                .HasOne<Category>(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId);

            modelBuilder.Entity<Product>()
                .HasMany(p => p.Images)
                .WithOne(i => i.Product)
                .HasForeignKey(i => i.ProductId);


            modelBuilder.Entity<Product>()
                .HasMany<OrderItem>(p => p.OrderItems)
                .WithOne(o => o.Product)
                .HasForeignKey(o => o.ProductId);

            modelBuilder.Entity<Product>()
                .HasMany<Review>(p => p.Reviews)
                .WithOne(r => r.Product)
                .HasForeignKey(r => r.ProductId);

            modelBuilder.Entity<OrderItem>()
                .HasOne<Order>(oi => oi.Order)
                .WithMany(o => o.OrderItems)
                .HasForeignKey(oi => oi.OrderId);

            modelBuilder.Entity<Order>()
                .HasOne<User>(o => o.User)
                .WithMany(u => u.Orders)
                .HasForeignKey(o => o.UserId);


            modelBuilder.Entity<User>()
                .HasMany<Review>(u => u.Reviews)
                .WithOne(r => r.User)
                .HasForeignKey(r => r.UserId);


            modelBuilder.Entity<User>()
               .HasOne<UserRole>(u => u.UserRole)
               .WithMany(ur => ur.Users)
               .HasForeignKey(u => u.UserRoleId);

            modelBuilder.Entity<User>()
                .HasMany<RefreshToken>(u => u.RefreshTokens)
                .WithOne(rf => rf.User)
                .HasForeignKey(rf => rf.UserId);

            modelBuilder.Entity<OrderItemProductAttribute>()
                .HasKey(oipa => oipa.Id);

            modelBuilder.Entity<OrderItemProductAttribute>()
                .HasOne<OrderItem>(oipa => oipa.OrderItem)
                .WithMany(oi => oi.OrderItemProductAttributes)
                .HasForeignKey(oipa => oipa.OrderItemId)
                .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<OrderItemProductAttribute>()
                .HasOne<ProductAttribute>(oipa => oipa.ProductAttribute)
                .WithMany(pa => pa.OrderItemProductAttributes)
                .HasForeignKey(oipa => oipa.ProductAttributeId)
                .OnDelete(DeleteBehavior.NoAction);


        }
    }
}


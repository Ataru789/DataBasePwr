using ksiegarnia_backend.Models;

namespace ksiegarnia_backend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ShippingInfo> ShippingInfos { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //relacja User-Customer
            modelBuilder.Entity<User>()
            .HasOne(u => u.Customer)
            .WithOne(c => c.User)
            .HasForeignKey<Customer>(c => c.UserId);
            //relacja User-Admin
            modelBuilder.Entity<User>()
            .HasOne(u => u.Admin)
            .WithOne(a => a.User)
            .HasForeignKey<Admin>(a => a.UserId);
            //relacja Author-Book
            modelBuilder.Entity<Author>()
            .HasMany(e => e.Books)
            .WithOne(e => e.Author)
            .HasForeignKey(e => e.AuthorId)
            .IsRequired();
            //relacja Customer-Order
            modelBuilder.Entity<Customer>()
            .HasMany(e => e.Orders)
            .WithOne(e => e.Customer)
            .HasForeignKey(e => e.CustomerId)
            .IsRequired();
            //relacja Order-OrderItem
            modelBuilder.Entity<Order>()
            .HasMany(e => e.OrderItems)
            .WithOne(e => e.Order)
            .HasForeignKey(e => e.OrderId)
            .IsRequired();
            //relacja OrderItem-Book
            modelBuilder.Entity<OrderItem>()
            .HasOne(e => e.Book)
            .WithMany(e => e.OrderItems)
            .HasForeignKey(e => e.BookId)
            .IsRequired();
            //relacja Order-ShippingInfo
            modelBuilder.Entity<Order>()
            .HasOne(e => e.ShippingInfo)
            .WithOne(e => e.Order)
            .HasForeignKey<ShippingInfo>(e => e.OrderId);
            //relacja Customer-ShoppingCart
            modelBuilder.Entity<Customer>()
            .HasMany(e => e.ShoppingCarts)
            .WithOne(e => e.Customer)
            .HasForeignKey(e => e.CustomerId)
            .IsRequired();
        }

    }
    }

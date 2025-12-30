using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Entities.Product>? Products { get; set; }
    public DbSet<Entities.Category>? Categories { get; set; }
    public DbSet<Entities.ProductImage>? ProductImages { get; set; }
    public DbSet<Entities.User>? Users { get; set; }
    public DbSet<Entities.Address>? Addresses { get; set; }
    public DbSet<Entities.Order>? Orders { get; set; }
    public DbSet<Entities.OrderItem>? OrderItems { get; set; }
    public DbSet<Entities.Cart>? Carts { get; set; }
    public DbSet<Entities.CartItem>? CartItems { get; set; }
    public DbSet<Entities.Payment>? Payments { get; set; }
    public DbSet<Entities.Shipment>? Shipments { get; set; }
    public DbSet<Entities.Review>? Reviews { get; set; }
    public DbSet<Entities.Coupon>? Coupons { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // simple configurations
        modelBuilder.Entity<Entities.Product>().HasIndex(p => p.SKU);
        modelBuilder.Entity<Entities.Category>().HasIndex(c => c.Slug);
        modelBuilder.Entity<Entities.User>().HasIndex(u => u.Email).IsUnique();
    }
}

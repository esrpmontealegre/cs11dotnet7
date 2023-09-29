using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Demo.Shared;

public partial class ShopeeContext : DbContext
{
    public ShopeeContext()
    {

    }

    public ShopeeContext(DbContextOptions<ShopeeContext> options)
        : base(options)
    {

    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<EmployeeTerritory> EmployeeTerritories { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Shipper> Shippers { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<Territory> Territories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured)
        {
            string dir = Environment.CurrentDirectory;
            string path = string.Empty;
            if (dir.EndsWith("net7.0"))
            {
                //will run in proj/bin/release
                path = Path.Combine("..", "..", "..", "..", "Shopee.db");
            }
            else
            {
                path = Path.Combine("..","Shopee.db");
            }

            optionsBuilder.UseSqlite($"Filename={path}");
        }
    }//=> optionsBuilder.UseSqlite("Filename=../Shopee.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {


        modelBuilder.Entity<OrderDetail>(entity =>
        {
            entity.HasKey(e => new { e.OrderId, e.ProductId });
            //entity.Property(e => e.Quantity).HasDefaultValueSql("1");
            //entity.Property(e => e.UnitPrice).HasDefaultValueSql("0");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderDetails).OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Product).WithMany(p => p.OrderDetails).OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Product>().Property(product => product.UnitPrice).HasConversion<double>();


        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

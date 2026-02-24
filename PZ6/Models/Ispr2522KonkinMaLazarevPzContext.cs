using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace PZ6.Models;

public partial class Ispr2522KonkinMaLazarevPzContext : DbContext
{
    public Ispr2522KonkinMaLazarevPzContext()
    {
    }

    public Ispr2522KonkinMaLazarevPzContext(DbContextOptions<Ispr2522KonkinMaLazarevPzContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Delivery> Deliveries { get; set; }

    public virtual DbSet<Manufacturer> Manufacturers { get; set; }

    public virtual DbSet<Name> Names { get; set; }

    public virtual DbSet<OrdersProduct> OrdersProducts { get; set; }

    public virtual DbSet<PickUpPoint> PickUpPoints { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductName> ProductNames { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=cfif31.ru;username=ISPr25-22_KonkinMA;password=ISPr25-22_KonkinMA;database=ISPr25-22_KonkinMA_LazarevPZ", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.45-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.IdCategory).HasName("PRIMARY");

            entity.ToTable("category");

            entity.Property(e => e.IdCategory).HasColumnName("id_category");
            entity.Property(e => e.CategoryName)
                .HasMaxLength(45)
                .HasColumnName("category_name");
        });

        modelBuilder.Entity<Delivery>(entity =>
        {
            entity.HasKey(e => e.IdDelivery).HasName("PRIMARY");

            entity.ToTable("delivery");

            entity.HasIndex(e => e.IdPickUpPoint, "fk_delivery_pick-up point_idx");

            entity.HasIndex(e => e.IdStatus, "fk_delivery_status_idx");

            entity.HasIndex(e => e.IdUser, "fk_delivery_user_idx");

            entity.Property(e => e.IdDelivery).HasColumnName("id_delivery");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.DateDelivery)
                .HasColumnType("datetime")
                .HasColumnName("date_delivery");
            entity.Property(e => e.DateOrder)
                .HasColumnType("datetime")
                .HasColumnName("date_order");
            entity.Property(e => e.IdPickUpPoint).HasColumnName("id_pick-up point");
            entity.Property(e => e.IdStatus).HasColumnName("id_status");
            entity.Property(e => e.IdUser).HasColumnName("id_user");

            entity.HasOne(d => d.IdPickUpPointNavigation).WithMany(p => p.Deliveries)
                .HasForeignKey(d => d.IdPickUpPoint)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_delivery_pick-up point");

            entity.HasOne(d => d.IdStatusNavigation).WithMany(p => p.Deliveries)
                .HasForeignKey(d => d.IdStatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_delivery_status");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.Deliveries)
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_delivery_user");
        });

        modelBuilder.Entity<Manufacturer>(entity =>
        {
            entity.HasKey(e => e.IdManufacturer).HasName("PRIMARY");

            entity.ToTable("manufacturer");

            entity.Property(e => e.IdManufacturer).HasColumnName("id_manufacturer");
            entity.Property(e => e.ManufacturerName)
                .HasMaxLength(45)
                .HasColumnName("manufacturer_name");
        });

        modelBuilder.Entity<Name>(entity =>
        {
            entity.HasKey(e => e.IdName).HasName("PRIMARY");

            entity.ToTable("name");

            entity.HasIndex(e => e.IdUser, "id_name_user_idx");

            entity.Property(e => e.IdName).HasColumnName("id_name");
            entity.Property(e => e.IdUser).HasColumnName("id_user");
            entity.Property(e => e.NameFio)
                .HasMaxLength(45)
                .HasColumnName("name_fio");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.Names)
                .HasForeignKey(d => d.IdUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("id_name_user");
        });

        modelBuilder.Entity<OrdersProduct>(entity =>
        {
            entity.HasKey(e => e.IdOrdersProducts).HasName("PRIMARY");

            entity.ToTable("orders_products");

            entity.HasIndex(e => e.IdDelivery, "fk_order_products_delivery_idx");

            entity.HasIndex(e => e.IdProduct, "fk_order_products_product_idx");

            entity.Property(e => e.IdOrdersProducts).HasColumnName("id_orders_products");
            entity.Property(e => e.Count).HasColumnName("count");
            entity.Property(e => e.IdDelivery).HasColumnName("id_delivery");
            entity.Property(e => e.IdProduct).HasColumnName("id_product");

            entity.HasOne(d => d.IdDeliveryNavigation).WithMany(p => p.OrdersProducts)
                .HasForeignKey(d => d.IdDelivery)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_order_products_delivery");

            entity.HasOne(d => d.IdProductNavigation).WithMany(p => p.OrdersProducts)
                .HasForeignKey(d => d.IdProduct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_order_products_product");
        });

        modelBuilder.Entity<PickUpPoint>(entity =>
        {
            entity.HasKey(e => e.IdPickUpPoint).HasName("PRIMARY");

            entity.ToTable("pick-up point");

            entity.Property(e => e.IdPickUpPoint).HasColumnName("id_pick-up point");
            entity.Property(e => e.Adress)
                .HasMaxLength(45)
                .HasColumnName("adress");
            entity.Property(e => e.Index)
                .HasMaxLength(45)
                .HasColumnName("index");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.IdProduct).HasName("PRIMARY");

            entity.ToTable("product");

            entity.HasIndex(e => e.IdCategory, "fk_product_category_idx");

            entity.HasIndex(e => e.IdManufacturer, "fk_product_manufacturer_idx");

            entity.HasIndex(e => e.IdProductName, "fk_product_product_name_idx");

            entity.HasIndex(e => e.IdSupplier, "fk_product_supplier_idx");

            entity.Property(e => e.IdProduct).HasColumnName("id_product");
            entity.Property(e => e.Article)
                .HasMaxLength(45)
                .HasColumnName("article");
            entity.Property(e => e.Count).HasColumnName("count");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Discount).HasColumnName("discount");
            entity.Property(e => e.IdCategory).HasColumnName("id_category");
            entity.Property(e => e.IdManufacturer).HasColumnName("id_manufacturer");
            entity.Property(e => e.IdProductName).HasColumnName("id_product name");
            entity.Property(e => e.IdSupplier).HasColumnName("id_supplier");
            entity.Property(e => e.Photo)
                .HasMaxLength(45)
                .HasColumnName("photo");
            entity.Property(e => e.Price)
                .HasPrecision(5)
                .HasColumnName("price");
            entity.Property(e => e.Unit)
                .HasMaxLength(45)
                .HasColumnName("unit");

            entity.HasOne(d => d.IdCategoryNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.IdCategory)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_product_category");

            entity.HasOne(d => d.IdManufacturerNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.IdManufacturer)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_product_manufacturer");

            entity.HasOne(d => d.IdProductNameNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.IdProductName)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_product_product_name");

            entity.HasOne(d => d.IdSupplierNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.IdSupplier)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_product_supplier");
        });

        modelBuilder.Entity<ProductName>(entity =>
        {
            entity.HasKey(e => e.IdProductName).HasName("PRIMARY");

            entity.ToTable("product name");

            entity.Property(e => e.IdProductName).HasColumnName("id_product name");
            entity.Property(e => e.ProductName1)
                .HasMaxLength(45)
                .HasColumnName("product name");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.IdRole).HasName("PRIMARY");

            entity.ToTable("role");

            entity.Property(e => e.IdRole).HasColumnName("id_role");
            entity.Property(e => e.RoleName)
                .HasMaxLength(45)
                .HasColumnName("role_name");
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.HasKey(e => e.IdStatus).HasName("PRIMARY");

            entity.ToTable("status");

            entity.Property(e => e.IdStatus).HasColumnName("id_status");
            entity.Property(e => e.StatusName)
                .HasMaxLength(45)
                .HasColumnName("status_name");
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.HasKey(e => e.IdSupplier).HasName("PRIMARY");

            entity.ToTable("supplier");

            entity.Property(e => e.IdSupplier).HasColumnName("id_supplier");
            entity.Property(e => e.SupplierName)
                .HasMaxLength(45)
                .HasColumnName("supplier_name");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.IdUser).HasName("PRIMARY");

            entity.ToTable("user");

            entity.HasIndex(e => e.IdRole, "fk_user_role_idx");

            entity.Property(e => e.IdUser).HasColumnName("id_user");
            entity.Property(e => e.IdRole).HasColumnName("id_role");
            entity.Property(e => e.Login)
                .HasMaxLength(45)
                .HasColumnName("login");
            entity.Property(e => e.Password)
                .HasMaxLength(45)
                .HasColumnName("password");

            entity.HasOne(d => d.IdRoleNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.IdRole)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_user_role");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

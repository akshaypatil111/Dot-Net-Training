﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EshoppingAPI.Model
{
    public partial class EshoppingDBContext : DbContext
    {
        public EshoppingDBContext()
        {
        }

        public EshoppingDBContext(DbContextOptions<EshoppingDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<FinalOrder> FinalOrders { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<MyOrder> MyOrders { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");

                entity.Property(e => e.CatName).HasMaxLength(50);
            });

            modelBuilder.Entity<FinalOrder>(entity =>
            {
                entity.ToTable("FinalOrder");

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.OrderName).HasMaxLength(50);

                entity.Property(e => e.OrderPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OrderQuantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.State).HasMaxLength(50);
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.ToTable("Login");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<MyOrder>(entity =>
            {
                entity.ToTable("MyOrder");

                entity.Property(e => e.ProductCategory).HasMaxLength(50);

                entity.Property(e => e.ProductName).HasMaxLength(50);

                entity.Property(e => e.ProductPrice).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.Category).HasMaxLength(50);

                entity.Property(e => e.ProductDiscount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProductMrp)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ProductMRP");

                entity.Property(e => e.ProductSellingPrice).HasColumnType("decimal(18, 2)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

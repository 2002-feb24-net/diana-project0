﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataBaseConnection.Model
{
    public partial class LimsGardenContext : DbContext
    {
        public LimsGardenContext()
        {
        }

        public LimsGardenContext(DbContextOptions<LimsGardenContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Plant> Plant { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(SecretConfiguration.secret);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
         // modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.CustomerId)
                    .HasColumnName("customer_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.FirstName)
                    .HasColumnName("first_name")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasColumnName("last_name")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.Property(e => e.LocationId)
                    .HasColumnName("location_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BranchName)
                    .HasColumnName("branch_name")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.StateName)
                    .HasColumnName("state_name")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.StreetAddress1)
                    .HasColumnName("street_address1")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.StreetAddress2)
                    .HasColumnName("street_address2")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Zipcode).HasColumnName("zipcode");
            });

            modelBuilder.Entity<OrderDetails>(entity =>
            {
                entity.HasKey(e => e.OrderItemId)
                    .HasName("PK__OrderDet__CBE3184E9F987868");

                entity.Property(e => e.OrderItemId)
                    .HasColumnName("orderItem_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.PlantId).HasColumnName("plant_id");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.TotalCost)
                    .HasColumnName("total_cost")
                    .HasColumnType("money");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK__OrderDeta__order__534D60F1");

                entity.HasOne(d => d.Plant)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.PlantId)
                    .HasConstraintName("FK__OrderDeta__plant__5441852A");
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__Orders__4659622954DC86C2");

                entity.Property(e => e.OrderId)
                    .HasColumnName("order_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.LocationId).HasColumnName("location_id");

                entity.Property(e => e.OrderTotal).HasColumnName("order_total");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__Orders__customer__4F7CD00D");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("FK__Orders__location__5070F446");
            });

            modelBuilder.Entity<Plant>(entity =>
            {
                entity.Property(e => e.PlantId)
                    .HasColumnName("plant_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cost).HasColumnName("cost");

                entity.Property(e => e.InventoryCount).HasColumnName("inventoryCount");

                entity.Property(e => e.PlantName)
                    .HasColumnName("plant_name")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

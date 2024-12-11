﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ksiegarnia_backend.Data;

#nullable disable

namespace ksiegarnia_backend.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241208122755_relacje")]
    partial class relacje
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("ksiegarnia_backend.Models.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("AdminId"));

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("AdminId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("ksiegarnia_backend.Models.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("AuthorId"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("ksiegarnia_backend.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("BookId"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<string>("Availability")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("BookId");

                    b.HasIndex("AuthorId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("ksiegarnia_backend.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("CustomerId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("ksiegarnia_backend.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ksiegarnia_backend.Models.OrderItem", b =>
                {
                    b.Property<int>("OrderItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("OrderItemId"));

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.Property<short>("Quantity")
                        .HasColumnType("smallint");

                    b.HasKey("OrderItemId");

                    b.HasIndex("BookId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("ksiegarnia_backend.Models.ShippingInfo", b =>
                {
                    b.Property<int>("ShippingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ShippingId"));

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("ShippingCost")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("ShippingStatus")
                        .HasColumnType("int");

                    b.HasKey("ShippingId");

                    b.HasIndex("OrderId")
                        .IsUnique();

                    b.ToTable("ShippingInfos");
                });

            modelBuilder.Entity("ksiegarnia_backend.Models.ShoppingCart", b =>
                {
                    b.Property<int>("CartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("CartId"));

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<short>("Quantity")
                        .HasColumnType("smallint");

                    b.HasKey("CartId");

                    b.HasIndex("CustomerId");

                    b.ToTable("ShoppingCarts");
                });

            modelBuilder.Entity("ksiegarnia_backend.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ksiegarnia_backend.Models.Admin", b =>
                {
                    b.HasOne("ksiegarnia_backend.Models.User", "User")
                        .WithOne("Admin")
                        .HasForeignKey("ksiegarnia_backend.Models.Admin", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ksiegarnia_backend.Models.Book", b =>
                {
                    b.HasOne("ksiegarnia_backend.Models.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("ksiegarnia_backend.Models.Customer", b =>
                {
                    b.HasOne("ksiegarnia_backend.Models.User", "User")
                        .WithOne("Customer")
                        .HasForeignKey("ksiegarnia_backend.Models.Customer", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ksiegarnia_backend.Models.Order", b =>
                {
                    b.HasOne("ksiegarnia_backend.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("ksiegarnia_backend.Models.OrderItem", b =>
                {
                    b.HasOne("ksiegarnia_backend.Models.Book", "Book")
                        .WithMany("OrderItems")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ksiegarnia_backend.Models.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("ksiegarnia_backend.Models.ShippingInfo", b =>
                {
                    b.HasOne("ksiegarnia_backend.Models.Order", "Order")
                        .WithOne("ShippingInfo")
                        .HasForeignKey("ksiegarnia_backend.Models.ShippingInfo", "OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("ksiegarnia_backend.Models.ShoppingCart", b =>
                {
                    b.HasOne("ksiegarnia_backend.Models.Customer", "Customer")
                        .WithMany("ShoppingCarts")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("ksiegarnia_backend.Models.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("ksiegarnia_backend.Models.Book", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("ksiegarnia_backend.Models.Customer", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("ShoppingCarts");
                });

            modelBuilder.Entity("ksiegarnia_backend.Models.Order", b =>
                {
                    b.Navigation("OrderItems");

                    b.Navigation("ShippingInfo")
                        .IsRequired();
                });

            modelBuilder.Entity("ksiegarnia_backend.Models.User", b =>
                {
                    b.Navigation("Admin")
                        .IsRequired();

                    b.Navigation("Customer")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

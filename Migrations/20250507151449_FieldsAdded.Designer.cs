﻿// <auto-generated />
using System;
using AD_Coursework.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AD_Coursework.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250507151449_FieldsAdded")]
    partial class FieldsAdded
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AD_Coursework.Models.Announcement", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Announcements");
                });

            modelBuilder.Entity("AD_Coursework.Models.Author", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Bio")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("AD_Coursework.Models.Book", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("AuthorId")
                        .HasColumnType("uuid");

                    b.Property<string>("CoverImageUrl")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Format")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("character varying(13)");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsAwardWinner")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsComingSoon")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsOnSale")
                        .HasColumnType("boolean");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("PublicationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("PublisherId")
                        .HasColumnType("uuid");

                    b.Property<int>("StockQuantity")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("PublisherId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("AD_Coursework.Models.BookGenre", b =>
                {
                    b.Property<Guid>("BookId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("GenreId")
                        .HasColumnType("uuid");

                    b.HasKey("BookId", "GenreId");

                    b.HasIndex("GenreId");

                    b.ToTable("BookGenres");
                });

            modelBuilder.Entity("AD_Coursework.Models.Cart", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("ItemCount")
                        .HasColumnType("integer");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("numeric");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("AD_Coursework.Models.CartItem", b =>
                {
                    b.Property<Guid>("CartId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("BookId")
                        .HasColumnType("uuid");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("numeric");

                    b.HasKey("CartId", "BookId");

                    b.HasIndex("BookId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("AD_Coursework.Models.Discount", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("BookId")
                        .HasColumnType("uuid");

                    b.Property<float>("DiscountPercentage")
                        .HasColumnType("real");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.ToTable("Discounts");
                });

            modelBuilder.Entity("AD_Coursework.Models.Genre", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("AD_Coursework.Models.Notification", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsRead")
                        .HasColumnType("boolean");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("AD_Coursework.Models.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CancellationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CancellationReason")
                        .HasColumnType("text");

                    b.Property<string>("ClaimCode")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<DateTime?>("CompletionDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<decimal>("DiscountAmount")
                        .HasColumnType("numeric");

                    b.Property<decimal>("DiscountPercentage")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<DateTime?>("PickupDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("PickupNotes")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<decimal>("Subtotal")
                        .HasColumnType("numeric");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("numeric");

                    b.Property<bool>("UsedBulkDiscount")
                        .HasColumnType("boolean");

                    b.Property<bool>("UsedLoyaltyDiscount")
                        .HasColumnType("boolean");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("AD_Coursework.Models.OrderItem", b =>
                {
                    b.Property<Guid>("OrderId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("BookId")
                        .HasColumnType("uuid");

                    b.Property<decimal>("LineTotal")
                        .HasColumnType("numeric");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("numeric");

                    b.HasKey("OrderId", "BookId");

                    b.HasIndex("BookId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("AD_Coursework.Models.Publisher", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)");

                    b.HasKey("Id");

                    b.ToTable("Publishers");
                });

            modelBuilder.Entity("AD_Coursework.Models.Review", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("BookId")
                        .HasColumnType("uuid");

                    b.Property<string>("Comment")
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Rating")
                        .HasColumnType("integer");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("UserId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("AD_Coursework.Models.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("9f3b53b8-13e9-4c66-b45e-6c56d0b0d6db"),
                            ConcurrencyStamp = "2e9d1ca2-83fd-44cd-80b5-5f2ca8f8a573",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = new Guid("a87642e3-e4cd-45f4-8c6d-1a1f5f6c6709"),
                            ConcurrencyStamp = "1f9f8489-4b06-464a-8122-3dbd955e7f82",
                            Name = "Staff",
                            NormalizedName = "STAFF"
                        },
                        new
                        {
                            Id = new Guid("b8fd98e7-3a5b-4275-b4bb-8c7ccda0d6b0"),
                            ConcurrencyStamp = "3f39bee8-26a3-409f-ba1e-1d3a3f90f8fa",
                            Name = "Member",
                            NormalizedName = "MEMBER"
                        });
                });

            modelBuilder.Entity("AD_Coursework.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("Address")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<bool>("IsEligibleForLoyaltyDiscount")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<int>("TotalOrdersCompleted")
                        .HasColumnType("integer");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("c4ca2613-69c6-4689-989a-c8d93037c93e"),
                            AccessFailedCount = 0,
                            Address = "Kathmandu, Nepal",
                            ConcurrencyStamp = "ee81d9ce-806d-40f1-95ba-641b32ccbffb",
                            Email = "admin@bookstore.com",
                            EmailConfirmed = true,
                            FullName = "System Administrator",
                            IsEligibleForLoyaltyDiscount = false,
                            LockoutEnabled = true,
                            NormalizedEmail = "ADMIN@BOOKSTORE.COM",
                            NormalizedUserName = "ADMIN@BOOKSTORE",
                            PasswordHash = "AQAAAAIAAYagAAAAELJrJRaeIdQtdGz9BEEOwU3y1U0CkNpg8L91NGHI3+i14iY8XamphKLlI69Ai56H0g==",
                            PhoneNumber = "1234567890",
                            PhoneNumberConfirmed = true,
                            RegistrationDate = new DateTime(2025, 5, 7, 15, 14, 48, 720, DateTimeKind.Utc).AddTicks(1728),
                            RoleId = new Guid("9f3b53b8-13e9-4c66-b45e-6c56d0b0d6db"),
                            SecurityStamp = "6f8117a6-8a9d-4c99-ad7c-007cfc6d045b",
                            TotalOrdersCompleted = 0,
                            TwoFactorEnabled = false,
                            UserName = "admin@bookstore"
                        },
                        new
                        {
                            Id = new Guid("69daaad5-eac4-4c6f-ab7c-cafce1b7889c"),
                            AccessFailedCount = 0,
                            Address = "Kathmandu, Nepal",
                            ConcurrencyStamp = "42e44fe7-797a-416b-893d-66761c9e9c30",
                            Email = "staff@bookstore.com",
                            EmailConfirmed = true,
                            FullName = "Bookstore Staff",
                            IsEligibleForLoyaltyDiscount = false,
                            LockoutEnabled = true,
                            NormalizedEmail = "STAFF@BOOKSTORE.COM",
                            NormalizedUserName = "STAFF@BOOKSTORE",
                            PasswordHash = "AQAAAAIAAYagAAAAEFEnhLYQMBe58bhKEo5uG8c2AVzcFKJoTH/9MADUKHXQJ2pnX5ftxJmfJtAfUYaNtg==",
                            PhoneNumber = "0987654321",
                            PhoneNumberConfirmed = true,
                            RegistrationDate = new DateTime(2025, 5, 7, 15, 14, 48, 760, DateTimeKind.Utc).AddTicks(8317),
                            RoleId = new Guid("a87642e3-e4cd-45f4-8c6d-1a1f5f6c6709"),
                            SecurityStamp = "1ff9fefa-a235-4075-b400-c4aed916717c",
                            TotalOrdersCompleted = 0,
                            TwoFactorEnabled = false,
                            UserName = "staff@bookstore"
                        });
                });

            modelBuilder.Entity("AD_Coursework.Models.WhitelistItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("AddedOn")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("BookId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("UserId");

                    b.ToTable("WhitelistedItems");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("AD_Coursework.Models.Book", b =>
                {
                    b.HasOne("AD_Coursework.Models.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("AD_Coursework.Models.Publisher", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("AD_Coursework.Models.BookGenre", b =>
                {
                    b.HasOne("AD_Coursework.Models.Book", "Book")
                        .WithMany("BookGenres")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AD_Coursework.Models.Genre", "Genre")
                        .WithMany("BookGenres")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("AD_Coursework.Models.Cart", b =>
                {
                    b.HasOne("AD_Coursework.Models.User", "User")
                        .WithOne("Cart")
                        .HasForeignKey("AD_Coursework.Models.Cart", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("AD_Coursework.Models.CartItem", b =>
                {
                    b.HasOne("AD_Coursework.Models.Book", "Book")
                        .WithMany("CartItems")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AD_Coursework.Models.Cart", "Cart")
                        .WithMany("Items")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Cart");
                });

            modelBuilder.Entity("AD_Coursework.Models.Discount", b =>
                {
                    b.HasOne("AD_Coursework.Models.Book", "Book")
                        .WithMany("Discounts")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");
                });

            modelBuilder.Entity("AD_Coursework.Models.Notification", b =>
                {
                    b.HasOne("AD_Coursework.Models.User", "User")
                        .WithMany("Notifications")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("AD_Coursework.Models.Order", b =>
                {
                    b.HasOne("AD_Coursework.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("AD_Coursework.Models.OrderItem", b =>
                {
                    b.HasOne("AD_Coursework.Models.Book", "Book")
                        .WithMany("OrderItems")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("AD_Coursework.Models.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("AD_Coursework.Models.Review", b =>
                {
                    b.HasOne("AD_Coursework.Models.Book", "Book")
                        .WithMany("Reviews")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AD_Coursework.Models.User", "User")
                        .WithMany("Reviews")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("User");
                });

            modelBuilder.Entity("AD_Coursework.Models.User", b =>
                {
                    b.HasOne("AD_Coursework.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("AD_Coursework.Models.WhitelistItem", b =>
                {
                    b.HasOne("AD_Coursework.Models.Book", "Book")
                        .WithMany("WhitelistItems")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AD_Coursework.Models.User", "User")
                        .WithMany("WhitelistItems")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("AD_Coursework.Models.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("AD_Coursework.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("AD_Coursework.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("AD_Coursework.Models.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AD_Coursework.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("AD_Coursework.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AD_Coursework.Models.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("AD_Coursework.Models.Book", b =>
                {
                    b.Navigation("BookGenres");

                    b.Navigation("CartItems");

                    b.Navigation("Discounts");

                    b.Navigation("OrderItems");

                    b.Navigation("Reviews");

                    b.Navigation("WhitelistItems");
                });

            modelBuilder.Entity("AD_Coursework.Models.Cart", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("AD_Coursework.Models.Genre", b =>
                {
                    b.Navigation("BookGenres");
                });

            modelBuilder.Entity("AD_Coursework.Models.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("AD_Coursework.Models.Publisher", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("AD_Coursework.Models.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("AD_Coursework.Models.User", b =>
                {
                    b.Navigation("Cart");

                    b.Navigation("Notifications");

                    b.Navigation("Orders");

                    b.Navigation("Reviews");

                    b.Navigation("WhitelistItems");
                });
#pragma warning restore 612, 618
        }
    }
}

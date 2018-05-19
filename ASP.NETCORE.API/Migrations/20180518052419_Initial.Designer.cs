﻿// <auto-generated />
using ASP.NETCORE.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace ASP.NETCORE.API.Migrations
{
    [DbContext(typeof(TravelAgencyDataBaseContext))]
    [Migration("20180518052419_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ASP.NETCORE.API.Models.ClientProfile", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(128);

                    b.Property<string>("Address")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<int?>("Age");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Password")
                        .IsUnicode(false);

                    b.Property<int?>("RoleId");

                    b.Property<string>("Surname")
                        .HasColumnType("nchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("ClientProfile");
                });

            modelBuilder.Entity("ASP.NETCORE.API.Models.Conditions", b =>
                {
                    b.Property<int>("ConditionId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConditionName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.HasKey("ConditionId");

                    b.ToTable("Conditions");
                });

            modelBuilder.Entity("ASP.NETCORE.API.Models.Deals", b =>
                {
                    b.Property<int>("DealId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<int>("ConditionId");

                    b.Property<DateTime>("DealConclusionDate")
                        .HasColumnType("date");

                    b.Property<float?>("DealDiscountRate");

                    b.Property<int>("DealNubmerAdults");

                    b.Property<int?>("DealNumberChildren");

                    b.Property<string>("EmployeeId")
                        .HasMaxLength(128);

                    b.Property<int>("TourId");

                    b.HasKey("DealId");

                    b.HasIndex("ClientId");

                    b.HasIndex("ConditionId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("TourId");

                    b.ToTable("Deals");
                });

            modelBuilder.Entity("ASP.NETCORE.API.Models.Foods", b =>
                {
                    b.Property<int>("FoodId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FoodName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("FoodId");

                    b.ToTable("Foods");
                });

            modelBuilder.Entity("ASP.NETCORE.API.Models.Photos", b =>
                {
                    b.Property<int>("PhotoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("PhotoName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("UrlLlink")
                        .HasColumnName("UrlLLink")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.HasKey("PhotoId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("ASP.NETCORE.API.Models.PlaceDestinations", b =>
                {
                    b.Property<int>("PlaceDestinationId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.HasKey("PlaceDestinationId");

                    b.ToTable("PlaceDestinations");
                });

            modelBuilder.Entity("ASP.NETCORE.API.Models.Roles", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("RoleName")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("ASP.NETCORE.API.Models.Rooms", b =>
                {
                    b.Property<int>("RoomId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("RoomCapacity");

                    b.Property<string>("RoomName")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("RoomId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("ASP.NETCORE.API.Models.TouristDestinations", b =>
                {
                    b.Property<int>("TouristDestinationId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("FoodId");

                    b.Property<string>("HotelName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<int?>("NumberStars");

                    b.Property<int?>("PhotoId");

                    b.Property<int>("PlaceDestinationId");

                    b.Property<int?>("RoomId");

                    b.HasKey("TouristDestinationId");

                    b.HasIndex("FoodId");

                    b.HasIndex("PhotoId");

                    b.HasIndex("PlaceDestinationId");

                    b.HasIndex("RoomId");

                    b.ToTable("TouristDestinations");
                });

            modelBuilder.Entity("ASP.NETCORE.API.Models.TourOperators", b =>
                {
                    b.Property<int>("TourOperatorId")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("Commission");

                    b.Property<string>("TourOperatorName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.HasKey("TourOperatorId");

                    b.ToTable("TourOperators");
                });

            modelBuilder.Entity("ASP.NETCORE.API.Models.Tours", b =>
                {
                    b.Property<int>("TourId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("TourArrivalDate")
                        .HasColumnType("date");

                    b.Property<float>("TourCost");

                    b.Property<DateTime>("TourDepartureDate")
                        .HasColumnType("date");

                    b.Property<int?>("TourNumberPersons");

                    b.Property<int?>("TourNumberTransactions");

                    b.Property<int?>("TourOperatorId");

                    b.Property<int?>("TouristDestinationId");

                    b.Property<int?>("TransportId");

                    b.HasKey("TourId");

                    b.HasIndex("TourOperatorId");

                    b.HasIndex("TouristDestinationId");

                    b.HasIndex("TransportId");

                    b.ToTable("Tours");
                });

            modelBuilder.Entity("ASP.NETCORE.API.Models.Transports", b =>
                {
                    b.Property<int>("TransportId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("TransportName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.HasKey("TransportId");

                    b.ToTable("Transports");
                });

            modelBuilder.Entity("ASP.NETCORE.API.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ASP.NETCORE.API.Models.ClientProfile", b =>
                {
                    b.HasOne("ASP.NETCORE.API.Models.Roles", "Role")
                        .WithMany("ClientProfile")
                        .HasForeignKey("RoleId")
                        .HasConstraintName("FK_ClientProfile_ClientProfile");
                });

            modelBuilder.Entity("ASP.NETCORE.API.Models.Deals", b =>
                {
                    b.HasOne("ASP.NETCORE.API.Models.ClientProfile", "Client")
                        .WithMany("DealsClient")
                        .HasForeignKey("ClientId")
                        .HasConstraintName("FK_Deals_ClientProfile");

                    b.HasOne("ASP.NETCORE.API.Models.Conditions", "Condition")
                        .WithMany("Deals")
                        .HasForeignKey("ConditionId")
                        .HasConstraintName("FK_Deal_Condition");

                    b.HasOne("ASP.NETCORE.API.Models.ClientProfile", "Employee")
                        .WithMany("DealsEmployee")
                        .HasForeignKey("EmployeeId")
                        .HasConstraintName("FK_Deals_ClientProfile1");

                    b.HasOne("ASP.NETCORE.API.Models.Tours", "Tour")
                        .WithMany("Deals")
                        .HasForeignKey("TourId")
                        .HasConstraintName("FK_Deal_Tour");
                });

            modelBuilder.Entity("ASP.NETCORE.API.Models.TouristDestinations", b =>
                {
                    b.HasOne("ASP.NETCORE.API.Models.Foods", "Food")
                        .WithMany()
                        .HasForeignKey("FoodId");

                    b.HasOne("ASP.NETCORE.API.Models.Photos", "Photo")
                        .WithMany()
                        .HasForeignKey("PhotoId");

                    b.HasOne("ASP.NETCORE.API.Models.PlaceDestinations", "PlaceDestination")
                        .WithMany()
                        .HasForeignKey("PlaceDestinationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ASP.NETCORE.API.Models.Rooms", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId");
                });

            modelBuilder.Entity("ASP.NETCORE.API.Models.Tours", b =>
                {
                    b.HasOne("ASP.NETCORE.API.Models.TourOperators", "TourOperator")
                        .WithMany()
                        .HasForeignKey("TourOperatorId");

                    b.HasOne("ASP.NETCORE.API.Models.TouristDestinations", "TouristDestination")
                        .WithMany()
                        .HasForeignKey("TouristDestinationId");

                    b.HasOne("ASP.NETCORE.API.Models.Transports", "Transport")
                        .WithMany()
                        .HasForeignKey("TransportId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ASP.NETCORE.API.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ASP.NETCORE.API.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ASP.NETCORE.API.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ASP.NETCORE.API.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

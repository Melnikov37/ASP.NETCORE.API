using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ASP.NETCORE.API.Models
{
    public partial class TravelAgencyDataBaseContext : DbContext
    {
        public virtual DbSet<ClientProfile> ClientProfile { get; set; }
        public virtual DbSet<Conditions> Conditions { get; set; }
        public virtual DbSet<Deals> Deals { get; set; }
        public virtual DbSet<Foods> Foods { get; set; }
        public virtual DbSet<Photos> Photos { get; set; }
        public virtual DbSet<PlaceDestinations> PlaceDestinations { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Rooms> Rooms { get; set; }
        public virtual DbSet<TouristDestinations> TouristDestinations { get; set; }
        public virtual DbSet<TourOperators> TourOperators { get; set; }
        public virtual DbSet<Tours> Tours { get; set; }
        public virtual DbSet<Transports> Transports { get; set; }

        public TravelAgencyDataBaseContext(DbContextOptions<TravelAgencyDataBaseContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClientProfile>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(128)
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password).IsUnicode(false);

                entity.Property(e => e.Surname).HasColumnType("nchar(10)");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.ClientProfile)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_ClientProfile_ClientProfile");
            });

            modelBuilder.Entity<Conditions>(entity =>
            {
                entity.HasKey(e => e.ConditionId);

                entity.Property(e => e.ConditionName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Deals>(entity =>
            {
                entity.HasKey(e => e.DealId);

                entity.Property(e => e.ClientId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.DealConclusionDate).HasColumnType("date");

                entity.Property(e => e.EmployeeId).HasMaxLength(128);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.DealsClient)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Deals_ClientProfile");

                entity.HasOne(d => d.Condition)
                    .WithMany(p => p.Deals)
                    .HasForeignKey(d => d.ConditionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Deal_Condition");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.DealsEmployee)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_Deals_ClientProfile1");

                entity.HasOne(d => d.Tour)
                    .WithMany(p => p.Deals)
                    .HasForeignKey(d => d.TourId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Deal_Tour");
            });

            modelBuilder.Entity<Foods>(entity =>
            {
                entity.HasKey(e => e.FoodId);

                entity.Property(e => e.FoodName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Photos>(entity =>
            {
                entity.HasKey(e => e.PhotoId);

                entity.Property(e => e.PhotoName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UrlLlink)
                    .HasColumnName("UrlLLink")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PlaceDestinations>(entity =>
            {
                entity.HasKey(e => e.PlaceDestinationId);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.HasKey(e => e.RoleId);

                entity.Property(e => e.RoleName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Rooms>(entity =>
            {
                entity.HasKey(e => e.RoomId);

                entity.Property(e => e.RoomName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TouristDestinations>(entity =>
            {
                entity.HasKey(e => e.TouristDestinationId);

                entity.Property(e => e.HotelName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                //entity.HasOne(d => d.Food)
                //    .WithMany(p => p.TouristDestinations)
                //    .HasForeignKey(d => d.FoodId)
                //    .HasConstraintName("FK_Tourist_destination_Food");

                //entity.HasOne(d => d.Photo)
                //    .WithMany(p => p.TouristDestinations)
                //    .HasForeignKey(d => d.PhotoId)
                //    .HasConstraintName("FK_Tourist_destination_Photo");

                //entity.HasOne(d => d.PlaceDestination)
                //    .WithMany(p => p.TouristDestinations)
                //    .HasForeignKey(d => d.PlaceDestinationId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_Tourist_destination_Place_destination");

                //entity.HasOne(d => d.Room)
                //    .WithMany(p => p.TouristDestinations)
                //    .HasForeignKey(d => d.RoomId)
                //    .HasConstraintName("FK_Tourist_destination_Room");
            });

            modelBuilder.Entity<TourOperators>(entity =>
            {
                entity.HasKey(e => e.TourOperatorId);

                entity.Property(e => e.TourOperatorName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tours>(entity =>
            {
                entity.HasKey(e => e.TourId);

                entity.Property(e => e.TourArrivalDate).HasColumnType("date");

                entity.Property(e => e.TourDepartureDate).HasColumnType("date");

                //entity.HasOne(d => d.TourOperator)
                //    .WithMany(p => p.Tours)
                //    .HasForeignKey(d => d.TourOperatorId)
                //    .HasConstraintName("FK_Tour_Tour_operator");

                //entity.HasOne(d => d.TouristDestination)
                //    .WithMany(p => p.Tours)
                //    .HasForeignKey(d => d.TouristDestinationId)
                //    .HasConstraintName("FK_Tour_Tourist_destination");

                //entity.HasOne(d => d.Transport)
                //    .WithMany(p => p.Tours)
                //    .HasForeignKey(d => d.TransportId)
                //    .HasConstraintName("FK_Tour_Transport");
            });

            modelBuilder.Entity<Transports>(entity =>
            {
                entity.HasKey(e => e.TransportId);

                entity.Property(e => e.TransportName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });
        }
    }
}

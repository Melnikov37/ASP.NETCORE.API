using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ASP.NETCORE.API.Models
{
    public partial class TravelAgencyDataBaseContext : IdentityDbContext<User>
    {
        public TravelAgencyDataBaseContext(DbContextOptions<TravelAgencyDataBaseContext> options)
            : base(options)
        { }
        public virtual DbSet<BusinessSer> BusinessSer { get; set; }
        public virtual DbSet<BusinessSerAtTour> BusinessSerAtTour { get; set; }
        public virtual DbSet<CleaningSer> CleaningSer { get; set; }
        public virtual DbSet<CleaningSerAtTour> CleaningSerAtTour { get; set; }
        public virtual DbSet<Conditions> Conditions { get; set; }
        public virtual DbSet<Deals> Deals { get; set; }
        public virtual DbSet<EntertaimentSer> EntertaimentSer { get; set; }
        public virtual DbSet<EntertaimentSerAtTour> EntertaimentSerAtTour { get; set; }
        public virtual DbSet<FoodType> FoodType { get; set; }
        public virtual DbSet<FoodTypeAtTour> FoodTypeAtTour { get; set; }
        public virtual DbSet<HealthAndBeautySer> HealthAndBeautySer { get; set; }
        public virtual DbSet<HealthAndBeautySerAtTour> HealthAndBeautySerAtTour { get; set; }
        public virtual DbSet<InternetSer> InternetSer { get; set; }
        public virtual DbSet<InternetSerAtTour> InternetSerAtTour { get; set; }
        public virtual DbSet<ParkingSer> ParkingSer { get; set; }
        public virtual DbSet<ParkingSerAtTour> ParkingSerAtTour { get; set; }
        public virtual DbSet<Photos> Photos { get; set; }
        public virtual DbSet<PlaceDestinations> PlaceDestinations { get; set; }
        public virtual DbSet<Rating> Rating { get; set; }
        public virtual DbSet<RestOnWaterSer> RestOnWaterSer { get; set; }
        public virtual DbSet<RestOnWaterSerAtTour> RestOnWaterSerAtTour { get; set; }
        public virtual DbSet<RoomFacilities> RoomFacilities { get; set; }
        public virtual DbSet<RoomFacilitiesAtTour> RoomFacilitiesAtTour { get; set; }
        public virtual DbSet<RoomType> RoomType { get; set; }
        public virtual DbSet<RoomTypeAtTour> RoomTypeAtTour { get; set; }
        public virtual DbSet<SmokingSer> SmokingSer { get; set; }
        public virtual DbSet<SmokingSerAtTour> SmokingSerAtTour { get; set; }
        public virtual DbSet<SportSer> SportSer { get; set; }
        public virtual DbSet<SportSerAtTour> SportSerAtTour { get; set; }
        public virtual DbSet<TouristDestinations> TouristDestinations { get; set; }
        public virtual DbSet<TourOperators> TourOperators { get; set; }
        public virtual DbSet<Tours> Tours { get; set; }
        public virtual DbSet<Transports> Transports { get; set; }
        public virtual DbSet<TransportSer> TransportSer { get; set; }
        public virtual DbSet<TransportSerAtTour> TransportSerAtTour { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=TravelAgencyDataBaseAuth;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<BusinessSer>(entity =>
            {
                entity.Property(e => e.BusinessSerName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BusinessSerAtTour>(entity =>
            {
                entity.HasKey(e => e.BusinessSerArTourId);

                //entity.HasOne(d => d.BusinessSer)
                //    .WithMany(p => p.BusinessSerAtTour)
                //    .HasForeignKey(d => d.BusinessSerId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_BusinessSerAtTour_BusinessSer");
            });

            modelBuilder.Entity<CleaningSer>(entity =>
            {
                entity.Property(e => e.CleaningSerName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CleaningSerAtTour>(entity =>
            {
                //entity.HasOne(d => d.CleaningSer)
                //    .WithMany(p => p.CleaningSerAtTour)
                //    .HasForeignKey(d => d.CleaningSerId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_CleaningSerAtTour_CleaningSer");

                //entity.HasOne(d => d.TouristDestination)
                //    .WithMany(p => p.CleaningSerAtTour)
                //    .HasForeignKey(d => d.TouristDestinationId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_CleaningSerAtTour_CleaningSerAtTour");
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

                entity.Property(e => e.DealConclusionDate).HasColumnType("date");

                //entity.HasOne(d => d.Condition)
                //    .WithMany(p => p.Deals)
                //    .HasForeignKey(d => d.ConditionId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_Deals_Conditions");

                //entity.HasOne(d => d.Tour)
                //    .WithMany(p => p.Deals)
                //    .HasForeignKey(d => d.TourId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_Deals_Tours");
            });

            modelBuilder.Entity<EntertaimentSer>(entity =>
            {
                entity.Property(e => e.EntertaimentSerName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EntertaimentSerAtTour>(entity =>
            {
                //entity.HasOne(d => d.EntertaimentSer)
                //    .WithMany(p => p.EntertaimentSerAtTour)
                //    .HasForeignKey(d => d.EntertaimentSerId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_EntertaimentSerAtTour_EntertaimentSer");

                //entity.HasOne(d => d.TouristDestination)
                //    .WithMany(p => p.EntertaimentSerAtTour)
                //    .HasForeignKey(d => d.TouristDestinationId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_EntertaimentSerAtTour_TouristDestinations");
            });

            modelBuilder.Entity<FoodType>(entity =>
            {
                entity.Property(e => e.FoodTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FoodTypeAtTour>(entity =>
            {
                //entity.HasOne(d => d.FoodType)
                //    .WithMany(p => p.FoodTypeAtTour)
                //    .HasForeignKey(d => d.FoodTypeId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_FoodTypeAtTour_FoodType");

                //entity.HasOne(d => d.TouristDestination)
                //    .WithMany(p => p.FoodTypeAtTour)
                //    .HasForeignKey(d => d.TouristDestinationId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_FoodTypeAtTour_TouristDestinations");
            });

            modelBuilder.Entity<HealthAndBeautySer>(entity =>
            {
                entity.Property(e => e.HealthAndBeautySerName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HealthAndBeautySerAtTour>(entity =>
            {
                //entity.HasOne(d => d.HealthAndBeautySer)
                //    .WithMany(p => p.HealthAndBeautySerAtTour)
                //    .HasForeignKey(d => d.HealthAndBeautySerId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_HealthAndBeautySerAtTour_HealthAndBeautySer");

                //entity.HasOne(d => d.TouristDestination)
                //    .WithMany(p => p.HealthAndBeautySerAtTour)
                //    .HasForeignKey(d => d.TouristDestinationId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_HealthAndBeautySerAtTour_TouristDestinations");
            });

            modelBuilder.Entity<InternetSer>(entity =>
            {
                entity.Property(e => e.InternetSerName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InternetSerAtTour>(entity =>
            {
                //entity.HasOne(d => d.InternetSer)
                //    .WithMany(p => p.InternetSerAtTour)
                //    .HasForeignKey(d => d.InternetSerId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_InternetSerAtTour_InternetSer");

                //entity.HasOne(d => d.TouristDestinations)
                //    .WithMany(p => p.InternetSerAtTour)
                //    .HasForeignKey(d => d.TouristDestinationsId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_InternetSerAtTour_TouristDestinations");
            });

            modelBuilder.Entity<ParkingSer>(entity =>
            {
                entity.Property(e => e.ParkingSerName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ParkingSerAtTour>(entity =>
            {
                //entity.HasOne(d => d.ParkingSer)
                //    .WithMany(p => p.ParkingSerAtTour)
                //    .HasForeignKey(d => d.ParkingSerId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_ParkingSerAtTour_ParkingSer");

                //entity.HasOne(d => d.TouristDestinations)
                //    .WithMany(p => p.ParkingSerAtTour)
                //    .HasForeignKey(d => d.TouristDestinationsId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_ParkingSerAtTour_TouristDestinations");
            });

            modelBuilder.Entity<Photos>(entity =>
            {
                entity.HasKey(e => e.PhotoId);

                entity.Property(e => e.PhotoName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UrlLlink)
                    .IsRequired()
                    .HasColumnName("UrlLLink")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                //entity.HasOne(d => d.TouristDestination)
                //    .WithMany(p => p.Photos)
                //    .HasForeignKey(d => d.TouristDestinationId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_Photos_TouristDestinations");
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

            modelBuilder.Entity<Rating>(entity =>
            {
                //entity.HasOne(d => d.TouristDestinations)
                //    .WithMany(p => p.Rating)
                //    .HasForeignKey(d => d.TouristDestinationsId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_Rating_TouristDestinations");
            });

            modelBuilder.Entity<RestOnWaterSer>(entity =>
            {
                entity.Property(e => e.RestOnWaterSerName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RestOnWaterSerAtTour>(entity =>
            {
                //entity.HasOne(d => d.RestOnWaterSer)
                //    .WithMany(p => p.RestOnWaterSerAtTour)
                //    .HasForeignKey(d => d.RestOnWaterSerId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_RestOnWaterSerAtTour_RestOnWaterSer");

                //entity.HasOne(d => d.TouristDestination)
                //    .WithMany(p => p.RestOnWaterSerAtTour)
                //    .HasForeignKey(d => d.TouristDestinationId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_RestOnWaterSerAtTour_TouristDestinations");
            });

            modelBuilder.Entity<RoomFacilities>(entity =>
            {
                entity.Property(e => e.RoomFacilitiesName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RoomFacilitiesAtTour>(entity =>
            {
                //entity.HasOne(d => d.RoomFacilities)
                //    .WithMany(p => p.RoomFacilitiesAtTour)
                //    .HasForeignKey(d => d.RoomFacilitiesId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_RoomFacilitiesAtTour_RoomFacilities");

                //entity.HasOne(d => d.TouristDestinations)
                //    .WithMany(p => p.RoomFacilitiesAtTour)
                //    .HasForeignKey(d => d.TouristDestinationsId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_RoomFacilitiesAtTour_TouristDestinations");
            });

            modelBuilder.Entity<RoomType>(entity =>
            {
                entity.Property(e => e.RoomTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RoomTypeAtTour>(entity =>
            {
                //entity.HasOne(d => d.RoomType)
                //    .WithMany(p => p.RoomTypeAtTour)
                //    .HasForeignKey(d => d.RoomTypeId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_RoomTypeAtTour_RoomType");

                //entity.HasOne(d => d.TouristDestination)
                //    .WithMany(p => p.RoomTypeAtTour)
                //    .HasForeignKey(d => d.TouristDestinationId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_RoomTypeAtTour_TouristDestinations");
            });

            modelBuilder.Entity<SmokingSer>(entity =>
            {
                entity.Property(e => e.SmokingSerName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SmokingSerAtTour>(entity =>
            {
                //entity.HasOne(d => d.SmokingSer)
                //    .WithMany(p => p.SmokingSerAtTour)
                //    .HasForeignKey(d => d.SmokingSerId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_SmokingSerAtTour_SmokingSer");

                //entity.HasOne(d => d.TouristDestination)
                //    .WithMany(p => p.SmokingSerAtTour)
                //    .HasForeignKey(d => d.TouristDestinationId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_SmokingSerAtTour_TouristDestinations");
            });

            modelBuilder.Entity<SportSer>(entity =>
            {
                entity.Property(e => e.SportSerName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SportSerAtTour>(entity =>
            {
                //entity.HasOne(d => d.SportSer)
                //    .WithMany(p => p.SportSerAtTour)
                //    .HasForeignKey(d => d.SportSerId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_SportSerAtTour_SportSer");

                //entity.HasOne(d => d.TouristDestinations)
                //    .WithMany(p => p.SportSerAtTour)
                //    .HasForeignKey(d => d.TouristDestinationsId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_SportSerAtTour_TouristDestinations");
            });

            modelBuilder.Entity<TouristDestinations>(entity =>
            {
                entity.HasKey(e => e.TouristDestinationId);

                entity.Property(e => e.TouristDestinationId).ValueGeneratedOnAdd();

                entity.Property(e => e.DescriptionHotel)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.HotelEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HotelFax)
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.HotelName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HotelPhone)
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.HotelSite)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                //entity.HasOne(d => d.Photo)
                //    .WithMany(p => p.TouristDestinations)
                //    .HasForeignKey(d => d.PhotoId)
                //    .HasConstraintName("FK_Tourist_destination_Photo");

                //entity.HasOne(d => d.PlaceDestination)
                //    .WithMany(p => p.TouristDestinations)
                //    .HasForeignKey(d => d.PlaceDestinationId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_Tourist_destination_Place_destination");

                entity.HasOne(d => d.TouristDestination)
                    .WithOne(p => p.InverseTouristDestination)
                    .HasForeignKey<TouristDestinations>(d => d.TouristDestinationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TouristDestinations_TouristDestinations");
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

                entity.Property(e => e.PointDeparture)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TourArrivalDate).HasColumnType("date");

                entity.Property(e => e.TourDepartureDate).HasColumnType("date");

                //entity.HasOne(d => d.FoodType)
                //    .WithMany(p => p.Tours)
                //    .HasForeignKey(d => d.FoodTypeId)
                //    .HasConstraintName("FK_Tours_FoodType");

                //entity.HasOne(d => d.RoomType)
                //    .WithMany(p => p.Tours)
                //    .HasForeignKey(d => d.RoomTypeId)
                //    .HasConstraintName("FK_Tours_RoomType");

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

            modelBuilder.Entity<TransportSer>(entity =>
            {
                entity.Property(e => e.TransportSerName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TransportSerAtTour>(entity =>
            {
                //entity.HasOne(d => d.TouristDestinations)
                //    .WithMany(p => p.TransportSerAtTour)
                //    .HasForeignKey(d => d.TouristDestinationsId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_TransportSerAtTour_TouristDestinations");

                //entity.HasOne(d => d.TransportSer)
                //    .WithMany(p => p.TransportSerAtTour)
                //    .HasForeignKey(d => d.TransportSerId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_TransportSerAtTour_TransportSer");
            });
        }
    }
}

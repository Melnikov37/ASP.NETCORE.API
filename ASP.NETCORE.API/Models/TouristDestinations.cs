using System;
using System.Collections.Generic;

namespace ASP.NETCORE.API.Models
{
    public partial class TouristDestinations
    {
        public TouristDestinations()
        {
            CleaningSerAtTour = new HashSet<CleaningSerAtTour>();
            EntertaimentSerAtTour = new HashSet<EntertaimentSerAtTour>();
            FoodTypeAtTour = new HashSet<FoodTypeAtTour>();
            HealthAndBeautySerAtTour = new HashSet<HealthAndBeautySerAtTour>();
            InternetSerAtTour = new HashSet<InternetSerAtTour>();
            ParkingSerAtTour = new HashSet<ParkingSerAtTour>();
            Photos = new HashSet<Photos>();
            Rating = new HashSet<Rating>();
            RestOnWaterSerAtTour = new HashSet<RestOnWaterSerAtTour>();
            RoomFacilitiesAtTour = new HashSet<RoomFacilitiesAtTour>();
            RoomTypeAtTour = new HashSet<RoomTypeAtTour>();
            SmokingSerAtTour = new HashSet<SmokingSerAtTour>();
            SportSerAtTour = new HashSet<SportSerAtTour>();
            Tours = new HashSet<Tours>();
            TransportSerAtTour = new HashSet<TransportSerAtTour>();
        }

        public int TouristDestinationId { get; set; }
        public string HotelName { get; set; }
        public int? NumberStars { get; set; }
        public int PlaceDestinationId { get; set; }
        public int? PhotoId { get; set; }
        public string HotelSite { get; set; }
        public string HotelPhone { get; set; }
        public string HotelFax { get; set; }
        public string HotelEmail { get; set; }
        public int? NumberOfRooms { get; set; }
        public int? DistanceToAirport { get; set; }
        public string DescriptionHotel { get; set; }

        public Photos Photo { get; set; }
        public PlaceDestinations PlaceDestination { get; set; }
        public TouristDestinations TouristDestination { get; set; }
        public TouristDestinations InverseTouristDestination { get; set; }
        public ICollection<CleaningSerAtTour> CleaningSerAtTour { get; set; }
        public ICollection<EntertaimentSerAtTour> EntertaimentSerAtTour { get; set; }
        public ICollection<FoodTypeAtTour> FoodTypeAtTour { get; set; }
        public ICollection<HealthAndBeautySerAtTour> HealthAndBeautySerAtTour { get; set; }
        public ICollection<InternetSerAtTour> InternetSerAtTour { get; set; }
        public ICollection<ParkingSerAtTour> ParkingSerAtTour { get; set; }
        public ICollection<Photos> Photos { get; set; }
        public ICollection<Rating> Rating { get; set; }
        public ICollection<RestOnWaterSerAtTour> RestOnWaterSerAtTour { get; set; }
        public ICollection<RoomFacilitiesAtTour> RoomFacilitiesAtTour { get; set; }
        public ICollection<RoomTypeAtTour> RoomTypeAtTour { get; set; }
        public ICollection<SmokingSerAtTour> SmokingSerAtTour { get; set; }
        public ICollection<SportSerAtTour> SportSerAtTour { get; set; }
        public ICollection<Tours> Tours { get; set; }
        public ICollection<TransportSerAtTour> TransportSerAtTour { get; set; }
    }
}

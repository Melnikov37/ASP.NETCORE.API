using System;
using System.Collections.Generic;

namespace ASP.NETCORE.API.Models
{
    public partial class TouristDestinations
    {
        public TouristDestinations()
        {
            Tours = new HashSet<Tours>();
        }

        public int TouristDestinationId { get; set; }
        public string HotelName { get; set; }
        public int? NumberStars { get; set; }
        public int PlaceDestinationId { get; set; }
        public int? PhotoId { get; set; }
        public int? FoodId { get; set; }
        public int? RoomId { get; set; }

        public Foods Food { get; set; }
        public Photos Photo { get; set; }
        public PlaceDestinations PlaceDestination { get; set; }
        public Rooms Room { get; set; }
        public ICollection<Tours> Tours { get; set; }
    }
}

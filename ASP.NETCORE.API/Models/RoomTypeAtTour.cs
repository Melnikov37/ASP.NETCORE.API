using System;
using System.Collections.Generic;

namespace ASP.NETCORE.API.Models
{
    public partial class RoomTypeAtTour
    {
        public int RoomTypeAtTourId { get; set; }
        public int RoomTypeId { get; set; }
        public int TouristDestinationId { get; set; }

        public RoomType RoomType { get; set; }
        public TouristDestinations TouristDestination { get; set; }
    }
}

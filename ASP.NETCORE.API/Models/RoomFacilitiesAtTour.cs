using System;
using System.Collections.Generic;

namespace ASP.NETCORE.API.Models
{
    public partial class RoomFacilitiesAtTour
    {
        public int RoomFacilitiesAtTourId { get; set; }
        public int RoomFacilitiesId { get; set; }
        public int TouristDestinationsId { get; set; }

        public RoomFacilities RoomFacilities { get; set; }
        public TouristDestinations TouristDestinations { get; set; }
    }
}

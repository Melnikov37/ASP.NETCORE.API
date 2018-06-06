using System;
using System.Collections.Generic;

namespace ASP.NETCORE.API.Models
{
    public partial class ParkingSerAtTour
    {
        public int ParkingSerAtTourId { get; set; }
        public int ParkingSerId { get; set; }
        public int TouristDestinationsId { get; set; }

        public ParkingSer ParkingSer { get; set; }
        public TouristDestinations TouristDestinations { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ASP.NETCORE.API.Models
{
    public partial class TransportSerAtTour
    {
        public int TransportSerAtTourId { get; set; }
        public int TransportSerId { get; set; }
        public int TouristDestinationsId { get; set; }

        public TouristDestinations TouristDestinations { get; set; }
        public TransportSer TransportSer { get; set; }
    }
}

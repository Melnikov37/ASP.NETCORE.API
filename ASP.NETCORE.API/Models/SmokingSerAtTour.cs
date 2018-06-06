using System;
using System.Collections.Generic;

namespace ASP.NETCORE.API.Models
{
    public partial class SmokingSerAtTour
    {
        public int SmokingSerAtTourId { get; set; }
        public int SmokingSerId { get; set; }
        public int TouristDestinationId { get; set; }

        public SmokingSer SmokingSer { get; set; }
        public TouristDestinations TouristDestination { get; set; }
    }
}

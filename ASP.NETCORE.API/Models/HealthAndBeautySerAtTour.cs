using System;
using System.Collections.Generic;

namespace ASP.NETCORE.API.Models
{
    public partial class HealthAndBeautySerAtTour
    {
        public int HealthAndBeautySerAtTourId { get; set; }
        public int HealthAndBeautySerId { get; set; }
        public int TouristDestinationId { get; set; }

        public HealthAndBeautySer HealthAndBeautySer { get; set; }
        public TouristDestinations TouristDestination { get; set; }
    }
}

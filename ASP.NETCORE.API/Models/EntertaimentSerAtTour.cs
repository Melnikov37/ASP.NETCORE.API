using System;
using System.Collections.Generic;

namespace ASP.NETCORE.API.Models
{
    public partial class EntertaimentSerAtTour
    {
        public int EntertaimentSerAtTourId { get; set; }
        public int EntertaimentSerId { get; set; }
        public int TouristDestinationId { get; set; }

        public EntertaimentSer EntertaimentSer { get; set; }
        public TouristDestinations TouristDestination { get; set; }
    }
}

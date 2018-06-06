using System;
using System.Collections.Generic;

namespace ASP.NETCORE.API.Models
{
    public partial class RestOnWaterSerAtTour
    {
        public int RestOnWaterSerAtTourId { get; set; }
        public int RestOnWaterSerId { get; set; }
        public int TouristDestinationId { get; set; }

        public RestOnWaterSer RestOnWaterSer { get; set; }
        public TouristDestinations TouristDestination { get; set; }
    }
}

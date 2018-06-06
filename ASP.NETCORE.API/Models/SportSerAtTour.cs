using System;
using System.Collections.Generic;

namespace ASP.NETCORE.API.Models
{
    public partial class SportSerAtTour
    {
        public int SportSerAtTourId { get; set; }
        public int SportSerId { get; set; }
        public int TouristDestinationsId { get; set; }

        public SportSer SportSer { get; set; }
        public TouristDestinations TouristDestinations { get; set; }
    }
}

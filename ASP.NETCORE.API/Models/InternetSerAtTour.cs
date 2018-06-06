using System;
using System.Collections.Generic;

namespace ASP.NETCORE.API.Models
{
    public partial class InternetSerAtTour
    {
        public int InternetSerAtTourId { get; set; }
        public int InternetSerId { get; set; }
        public int TouristDestinationsId { get; set; }

        public InternetSer InternetSer { get; set; }
        public TouristDestinations TouristDestinations { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ASP.NETCORE.API.Models
{
    public partial class CleaningSerAtTour
    {
        public int CleaningSerAtTourId { get; set; }
        public int CleaningSerId { get; set; }
        public int TouristDestinationId { get; set; }

        public CleaningSer CleaningSer { get; set; }
        public TouristDestinations TouristDestination { get; set; }
    }
}

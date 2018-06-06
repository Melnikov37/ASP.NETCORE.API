using System;
using System.Collections.Generic;

namespace ASP.NETCORE.API.Models
{
    public partial class BusinessSerAtTour
    {
        public int BusinessSerArTourId { get; set; }
        public int BusinessSerId { get; set; }
        public int TouristDestinationId { get; set; }

        public BusinessSer BusinessSer { get; set; }
    }
}

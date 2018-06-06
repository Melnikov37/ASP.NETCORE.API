using System;
using System.Collections.Generic;

namespace ASP.NETCORE.API.Models
{
    public partial class Rating
    {
        public int UserId { get; set; }
        public int TouristDestinationsId { get; set; }
        public int RatingValue { get; set; }
        public int RatingId { get; set; }

        public TouristDestinations TouristDestinations { get; set; }
    }
}

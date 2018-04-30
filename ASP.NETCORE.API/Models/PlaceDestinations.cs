using System;
using System.Collections.Generic;

namespace ASP.NETCORE.API.Models
{
    public partial class PlaceDestinations
    {
        //public PlaceDestinations()
        //{
        //    TouristDestinations = new HashSet<TouristDestinations>();
        //}

        public int PlaceDestinationId { get; set; }
        public string Country { get; set; }
        public string City { get; set; }

        //public ICollection<TouristDestinations> TouristDestinations { get; set; }
    }
}

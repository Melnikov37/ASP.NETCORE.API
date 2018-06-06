using System;
using System.Collections.Generic;

namespace ASP.NETCORE.API.Models
{
    public partial class FoodTypeAtTour
    {
        public int FoodTypeAtTourId { get; set; }
        public int FoodTypeId { get; set; }
        public int TouristDestinationId { get; set; }

        public FoodType FoodType { get; set; }
        public TouristDestinations TouristDestination { get; set; }
    }
}

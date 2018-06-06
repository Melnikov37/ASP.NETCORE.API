using System;
using System.Collections.Generic;

namespace ASP.NETCORE.API.Models
{
    public partial class FoodType
    {
        public FoodType()
        {
            FoodTypeAtTour = new HashSet<FoodTypeAtTour>();
            Tours = new HashSet<Tours>();
        }

        public int FoodTypeId { get; set; }
        public string FoodTypeName { get; set; }

        public ICollection<FoodTypeAtTour> FoodTypeAtTour { get; set; }
        public ICollection<Tours> Tours { get; set; }
    }
}

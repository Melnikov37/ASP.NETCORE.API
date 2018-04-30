using System;
using System.Collections.Generic;

namespace ASP.NETCORE.API.Models
{
    public partial class Foods
    {
        //public Foods()
        //{
        //    TouristDestinations = new HashSet<TouristDestinations>();
        //}

        public int FoodId { get; set; }
        public string FoodName { get; set; }

        //public ICollection<TouristDestinations> TouristDestinations { get; set; }
    }
}

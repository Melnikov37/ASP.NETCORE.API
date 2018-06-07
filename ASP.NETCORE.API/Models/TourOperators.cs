using System;
using System.Collections.Generic;

namespace ASP.NETCORE.API.Models
{
    public partial class TourOperators
    {
        //public TourOperators()
        //{
        //    Tours = new HashSet<Tours>();
        //}

        public int TourOperatorId { get; set; }
        public string TourOperatorName { get; set; }
        public float Commission { get; set; }

        //public ICollection<Tours> Tours { get; set; }
    }
}

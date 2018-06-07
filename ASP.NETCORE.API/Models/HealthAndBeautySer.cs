using System;
using System.Collections.Generic;

namespace ASP.NETCORE.API.Models
{
    public partial class HealthAndBeautySer
    {
        //public HealthAndBeautySer()
        //{
        //    HealthAndBeautySerAtTour = new HashSet<HealthAndBeautySerAtTour>();
        //}

        public int HealthAndBeautySerId { get; set; }
        public string HealthAndBeautySerName { get; set; }

        //public ICollection<HealthAndBeautySerAtTour> HealthAndBeautySerAtTour { get; set; }
    }
}

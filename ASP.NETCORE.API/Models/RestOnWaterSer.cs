using System;
using System.Collections.Generic;

namespace ASP.NETCORE.API.Models
{
    public partial class RestOnWaterSer
    {
        //public RestOnWaterSer()
        //{
        //    RestOnWaterSerAtTour = new HashSet<RestOnWaterSerAtTour>();
        //}

        public int RestOnWaterSerId { get; set; }
        public string RestOnWaterSerName { get; set; }

        //public ICollection<RestOnWaterSerAtTour> RestOnWaterSerAtTour { get; set; }
    }
}

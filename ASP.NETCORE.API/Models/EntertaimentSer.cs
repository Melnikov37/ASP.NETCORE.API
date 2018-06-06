using System;
using System.Collections.Generic;

namespace ASP.NETCORE.API.Models
{
    public partial class EntertaimentSer
    {
        public EntertaimentSer()
        {
            EntertaimentSerAtTour = new HashSet<EntertaimentSerAtTour>();
        }

        public int EntertaimentSerId { get; set; }
        public string EntertaimentSerName { get; set; }

        public ICollection<EntertaimentSerAtTour> EntertaimentSerAtTour { get; set; }
    }
}

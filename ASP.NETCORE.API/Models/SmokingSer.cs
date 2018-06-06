using System;
using System.Collections.Generic;

namespace ASP.NETCORE.API.Models
{
    public partial class SmokingSer
    {
        public SmokingSer()
        {
            SmokingSerAtTour = new HashSet<SmokingSerAtTour>();
        }

        public int SmokingSerId { get; set; }
        public string SmokingSerName { get; set; }

        public ICollection<SmokingSerAtTour> SmokingSerAtTour { get; set; }
    }
}

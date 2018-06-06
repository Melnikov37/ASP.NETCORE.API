using System;
using System.Collections.Generic;

namespace ASP.NETCORE.API.Models
{
    public partial class InternetSer
    {
        public InternetSer()
        {
            InternetSerAtTour = new HashSet<InternetSerAtTour>();
        }

        public int InternetSerId { get; set; }
        public string InternetSerName { get; set; }

        public ICollection<InternetSerAtTour> InternetSerAtTour { get; set; }
    }
}

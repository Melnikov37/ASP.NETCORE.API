using System;
using System.Collections.Generic;

namespace ASP.NETCORE.API.Models
{
    public partial class BusinessSer
    {
        public BusinessSer()
        {
            BusinessSerAtTour = new HashSet<BusinessSerAtTour>();
        }

        public int BusinessSerId { get; set; }
        public string BusinessSerName { get; set; }

        public ICollection<BusinessSerAtTour> BusinessSerAtTour { get; set; }
    }
}

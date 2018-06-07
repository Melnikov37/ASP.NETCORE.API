using System;
using System.Collections.Generic;

namespace ASP.NETCORE.API.Models
{
    public partial class SportSer
    {
        //public SportSer()
        //{
        //    SportSerAtTour = new HashSet<SportSerAtTour>();
        //}

        public int SportSerId { get; set; }
        public string SportSerName { get; set; }

        //public ICollection<SportSerAtTour> SportSerAtTour { get; set; }
    }
}

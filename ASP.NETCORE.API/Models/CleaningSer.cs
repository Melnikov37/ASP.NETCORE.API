using System;
using System.Collections.Generic;

namespace ASP.NETCORE.API.Models
{
    public partial class CleaningSer
    {
        public CleaningSer()
        {
            CleaningSerAtTour = new HashSet<CleaningSerAtTour>();
        }

        public int CleaningSerId { get; set; }
        public string CleaningSerName { get; set; }

        public ICollection<CleaningSerAtTour> CleaningSerAtTour { get; set; }
    }
}

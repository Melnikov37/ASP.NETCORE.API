using System;
using System.Collections.Generic;

namespace ASP.NETCORE.API.Models
{
    public partial class TransportSer
    {
        public TransportSer()
        {
            TransportSerAtTour = new HashSet<TransportSerAtTour>();
        }

        public int TransportSerId { get; set; }
        public string TransportSerName { get; set; }

        public ICollection<TransportSerAtTour> TransportSerAtTour { get; set; }
    }
}

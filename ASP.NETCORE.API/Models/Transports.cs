using System;
using System.Collections.Generic;

namespace ASP.NETCORE.API.Models
{
    public partial class Transports
    {
        public Transports()
        {
            Tours = new HashSet<Tours>();
        }

        public int TransportId { get; set; }
        public string TransportName { get; set; }

        public ICollection<Tours> Tours { get; set; }
    }
}

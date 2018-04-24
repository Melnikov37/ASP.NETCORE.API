using System;
using System.Collections.Generic;

namespace ASP.NETCORE.API.Models
{
    public partial class Photos
    {
        public Photos()
        {
            TouristDestinations = new HashSet<TouristDestinations>();
        }

        public int PhotoId { get; set; }
        public string PhotoName { get; set; }
        public string UrlLlink { get; set; }

        public ICollection<TouristDestinations> TouristDestinations { get; set; }
    }
}

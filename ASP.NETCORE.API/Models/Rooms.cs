using System;
using System.Collections.Generic;

namespace ASP.NETCORE.API.Models
{
    public partial class Rooms
    {
        public Rooms()
        {
            TouristDestinations = new HashSet<TouristDestinations>();
        }

        public int RoomId { get; set; }
        public string RoomName { get; set; }
        public int RoomCapacity { get; set; }

        public ICollection<TouristDestinations> TouristDestinations { get; set; }
    }
}

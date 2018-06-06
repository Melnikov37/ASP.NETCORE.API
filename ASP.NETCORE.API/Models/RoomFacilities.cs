using System;
using System.Collections.Generic;

namespace ASP.NETCORE.API.Models
{
    public partial class RoomFacilities
    {
        public RoomFacilities()
        {
            RoomFacilitiesAtTour = new HashSet<RoomFacilitiesAtTour>();
        }

        public int RoomFacilitiesId { get; set; }
        public string RoomFacilitiesName { get; set; }

        public ICollection<RoomFacilitiesAtTour> RoomFacilitiesAtTour { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace ASP.NETCORE.API.Models
{
    public partial class RoomType
    {
        //public RoomType()
        //{
        //    RoomTypeAtTour = new HashSet<RoomTypeAtTour>();
        //    Tours = new HashSet<Tours>();
        //}

        public int RoomTypeId { get; set; }
        public string RoomTypeName { get; set; }

        //public ICollection<RoomTypeAtTour> RoomTypeAtTour { get; set; }
        //public ICollection<Tours> Tours { get; set; }
    }
}

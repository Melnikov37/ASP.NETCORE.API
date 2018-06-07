using System;
using System.Collections.Generic;

namespace ASP.NETCORE.API.Models
{
    public partial class ParkingSer
    {
        //public ParkingSer()
        //{
        //    ParkingSerAtTour = new HashSet<ParkingSerAtTour>();
        //}

        public int ParkingSerId { get; set; }
        public string ParkingSerName { get; set; }

        //public ICollection<ParkingSerAtTour> ParkingSerAtTour { get; set; }
    }
}

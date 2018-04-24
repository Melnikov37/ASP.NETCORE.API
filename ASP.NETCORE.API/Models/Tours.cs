using System;
using System.Collections.Generic;

namespace ASP.NETCORE.API.Models
{
    public partial class Tours
    {
        public Tours()
        {
            Deals = new HashSet<Deals>();
        }

        public int TourId { get; set; }
        public DateTime TourArrivalDate { get; set; }
        public DateTime TourDepartureDate { get; set; }
        public float TourCost { get; set; }
        public int? TourNumberTransactions { get; set; }
        public int? TouristDestinationId { get; set; }
        public int? TourOperatorId { get; set; }
        public int? TransportId { get; set; }
        public int? TourNumberPersons { get; set; }

        public TourOperators TourOperator { get; set; }
        public TouristDestinations TouristDestination { get; set; }
        public Transports Transport { get; set; }
        public ICollection<Deals> Deals { get; set; }
    }
}

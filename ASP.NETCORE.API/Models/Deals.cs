using System;
using System.Collections.Generic;

namespace ASP.NETCORE.API.Models
{
    public partial class Deals
    {
        public string ClientId { get; set; }
        public int TourId { get; set; }
        public DateTime DealConclusionDate { get; set; }
        public int DealNubmerAdults { get; set; }
        public int? DealNumberChildren { get; set; }
        public float? DealDiscountRate { get; set; }
        public string EmployeeId { get; set; }
        public int ConditionId { get; set; }
        public int DealId { get; set; }

        public ClientProfile Client { get; set; }
        public Conditions Condition { get; set; }
        public ClientProfile Employee { get; set; }
        public Tours Tour { get; set; }
    }
}

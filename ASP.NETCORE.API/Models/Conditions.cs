using System;
using System.Collections.Generic;

namespace ASP.NETCORE.API.Models
{
    public partial class Conditions
    {
        public Conditions()
        {
            Deals = new HashSet<Deals>();
        }

        public int ConditionId { get; set; }
        public string ConditionName { get; set; }

        public ICollection<Deals> Deals { get; set; }
    }
}

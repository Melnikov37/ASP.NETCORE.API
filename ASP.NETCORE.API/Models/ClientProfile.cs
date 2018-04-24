using System;
using System.Collections.Generic;

namespace ASP.NETCORE.API.Models
{
    public partial class ClientProfile
    {
        public ClientProfile()
        {
            DealsClient = new HashSet<Deals>();
            DealsEmployee = new HashSet<Deals>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int? Age { get; set; }
        public string Surname { get; set; }
        public string Mail { get; set; }
        public int? RoleId { get; set; }
        public string Password { get; set; }

        public Roles Role { get; set; }
        public ICollection<Deals> DealsClient { get; set; }
        public ICollection<Deals> DealsEmployee { get; set; }
    }
}

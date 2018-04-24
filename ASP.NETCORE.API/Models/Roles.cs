using System;
using System.Collections.Generic;

namespace ASP.NETCORE.API.Models
{
    public partial class Roles
    {
        public Roles()
        {
            ClientProfile = new HashSet<ClientProfile>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }

        public ICollection<ClientProfile> ClientProfile { get; set; }
    }
}

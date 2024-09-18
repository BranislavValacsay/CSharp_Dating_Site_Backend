using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Trydem.Models
{
    public class AppRole : IdentityRole<int>
    {
        public ICollection<AppUserRole> UserRoles { get; set; }
    }
}

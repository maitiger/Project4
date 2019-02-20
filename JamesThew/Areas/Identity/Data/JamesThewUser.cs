using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace JamesThew.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the JamesThewUser class
    public class JamesThewUser : IdentityUser
    {
        public int Id { get; set; }
        public string UserName  { get; set; }
        public string   Password { get; set; }
    }
}

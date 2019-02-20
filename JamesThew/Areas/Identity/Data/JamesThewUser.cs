using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace JamesThew.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the JamesThewUser class
    public class JamesThewUser : IdentityUser
    {
        [Key]
        public int Id { get; set; }
        public string UserName  { get; set; }
        public string   Password { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }
        public string Address { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

    }
}

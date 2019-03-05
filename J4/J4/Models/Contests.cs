using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace J4.Models
{
    public class Contests
    {
        public Contests()
        {
            this.role = Role.Free;
        }
        public int Id { get; set; }
        public string UrlVideo { get; set; }
        public string Name { get; set; }
        public string Describle { get; set; }
        public string LinkRegis { get; set; }
        public Role role { get; set; }
    }
}

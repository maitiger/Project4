using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace J4.Models
{
    public class Recipes
    {
        public Recipes()
        {
            this.role = Role.Free;
        }
        public int Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }

        public string Resources { get; set; }
        public string Recipe { get; set; }
        public Role role { get; set; }

    }
    public enum Role
    {
        Free = 0,
        Vip = 1
    }
}

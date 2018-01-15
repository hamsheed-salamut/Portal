using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Models
{
    public class UserDetails
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Tracker { get; set; }
        public bool Packing { get; set; }
        public bool Structure { get; set; }
    }
}

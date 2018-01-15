using Portal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Data
{
    public class UserData
    {
    
        public List<UserDetails> GetAllUserDetails()
        {
            List<UserDetails> userDetails = new List<UserDetails>
            {
                new UserDetails
                {
                    Id = 1,
                    Username = "hsalamut",
                    Password = "123",
                    Packing = false,
                    Tracker = true,
                    Structure = true
                },
                new UserDetails
                {
                    Id = 1,
                    Username = "simul1",
                    Password = "123",
                    Packing = true,
                    Tracker = true,
                    Structure = true
                },
                new UserDetails
                {
                    Id = 1,
                    Username = "simul2",
                    Password = "123",
                    Packing = false,
                    Tracker = false,
                    Structure = true
                },
                new UserDetails
                {
                    Id = 1,
                    Username = "simul3",
                    Password = "123",
                    Packing = true,
                    Tracker = false,
                    Structure = true
                },
            };

            return userDetails;
        }
    }
}

using Microsoft.AspNetCore.Identity;
using MilkTea68.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilkTea68.Data.Entities
{
    public class AppUser : IdentityUser<Guid>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Dob { get; set; }

        public List<Cart> Carts { get; set; }

        public List<Order> Orders { get; set; }

        public List<Transaction> Transactions { get; set; }
    }
}

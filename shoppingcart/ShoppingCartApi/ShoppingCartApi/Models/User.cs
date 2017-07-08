using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCartApi.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public double Salary { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public ICollection<Record> Records { get; set; }
    }
}

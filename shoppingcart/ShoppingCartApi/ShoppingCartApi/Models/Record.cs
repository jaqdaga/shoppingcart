using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCartApi.Models
{
    public class Record
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }
    }
}

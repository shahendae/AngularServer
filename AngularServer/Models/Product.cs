using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularServer.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public string ImageUrl { get; set; }
        public string Status { get; set; } //available or unavailable
        public Category Category { get; set; }
        public List<Order> Orders { get; set; }
    }
}
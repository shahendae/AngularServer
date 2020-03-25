using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularServer.Models
{
    public enum Action
    {
        Waiting = 0,
        Processing = 1,
        OutForDeliver = 2,
        Deliver = 3,
        Cancel = 4
    }
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int TotalAmount { get; set; }
        public Action Action { get; set; }
        public string Notes { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public List<Product> Products { get; set; }
    }
}
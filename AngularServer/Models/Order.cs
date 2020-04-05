using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AngularServer.Models
{
    
    public class Order
    {
        public int Id { get; set; }

        //[DataType(DataType.Date)]
       // [DisplayFormat(ApplyFormatInEditMode =true,DataFormatString ="{0:MM/dd/yyyy}")]
        public DateTime Date { get; set; }
        public int TotalAmount { get; set; }
        public string Action { get; set; }
        public string Notes { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public List<Product> Products { get; set; }
    }
}
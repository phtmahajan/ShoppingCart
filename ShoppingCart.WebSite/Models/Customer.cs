using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingCart.WebSite.Models
{
    public class Customer
    {
        public string productName { get; set; }
        public int quantity { get; set; }
        public decimal price { get; set; }
        public decimal subtotal { get; set; }
        public decimal grandtotal { get; set; }

    }

}
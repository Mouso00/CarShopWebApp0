using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarShopWebApp0.Models
{
    using System;
    using System.Collections.Generic;

    public class Cart
    {
        public List<Car> Cars { get; set; }
        public double Total { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string PaymentMethod { get; set; }
    }

}
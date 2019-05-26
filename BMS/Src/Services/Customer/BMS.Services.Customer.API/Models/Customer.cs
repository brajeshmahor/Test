using System;
using System.Collections.Generic;

namespace BMS.Services.Customer.API.Models
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public bool? IsActive { get; set; }
    }
}

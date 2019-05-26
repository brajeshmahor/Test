using System;
using System.Collections.Generic;

namespace BMS.Services.Order.API.Models
{
    public partial class Order
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public int Quantity { get; set; }
        public decimal Amount { get; set; }
    }
}

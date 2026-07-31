using System;
using System.Collections.Generic;

namespace SmartLogistics.Application.DTOs
{
    public class OrderDto
    {
        public Guid Id { get; set; }
        public string OrderNumber { get; set; }
        public Guid CustomerId { get; set; }
        public string Status { get; set; }
        public decimal TotalAmount { get; set; }
        public List<OrderItemDto> Items { get; set; } = new List<OrderItemDto>();
    }

    public class OrderItemDto
    {
        public Guid Id { get; set; }
        public string ProductSku { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}

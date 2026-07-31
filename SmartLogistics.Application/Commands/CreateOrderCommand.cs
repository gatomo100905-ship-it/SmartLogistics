using MediatR;
using SmartLogistics.Application.Interfaces;
using SmartLogistics.Domain.Entities.Order;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SmartLogistics.Application.Commands
{
    public class CreateOrderCommand : IRequest<Guid>
    {
        public string OrderNumber { get; set; }
        public Guid CustomerId { get; set; }
        public List<CreateOrderItemDto> Items { get; set; } = new List<CreateOrderItemDto>();
    }

    public class CreateOrderItemDto
    {
        public string ProductSku { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }

    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, Guid>
    {
        private readonly IApplicationDbContext _context;

        public CreateOrderCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var order = new Order
            {
                Id = Guid.NewGuid(),
                OrderNumber = request.OrderNumber,
                CustomerId = request.CustomerId,
                Status = "Pending",
                TotalAmount = 0
            };

            foreach (var item in request.Items)
            {
                var orderItem = new OrderItem
                {
                    Id = Guid.NewGuid(),
                    OrderId = order.Id,
                    ProductSku = item.ProductSku,
                    ProductName = item.ProductName,
                    Quantity = item.Quantity,
                    UnitPrice = item.UnitPrice
                };
                order.OrderItems.Add(orderItem);
                order.TotalAmount += orderItem.TotalPrice;
            }

            _context.Orders.Add(order);
            await _context.SaveChangesAsync(cancellationToken);

            return order.Id;
        }
    }
}

using MediatR;
using SmartLogistics.Application.Interfaces;
using SmartLogistics.Application.DTOs;
using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace SmartLogistics.Application.Queries
{
    public class GetOrderByIdQuery : IRequest<OrderDto>
    {
        public Guid Id { get; set; }
    }

    public class GetOrderByIdQueryHandler : IRequestHandler<GetOrderByIdQuery, OrderDto>
    {
        private readonly IApplicationDbContext _context;

        public GetOrderByIdQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<OrderDto> Handle(GetOrderByIdQuery request, CancellationToken cancellationToken)
        {
            var order = await _context.Orders
                .Include(o => o.OrderItems)
                .FirstOrDefaultAsync(o => o.Id == request.Id, cancellationToken);

            if (order == null) return null;

            return new OrderDto
            {
                Id = order.Id,
                OrderNumber = order.OrderNumber,
                CustomerId = order.CustomerId,
                Status = order.Status,
                TotalAmount = order.TotalAmount,
                Items = order.OrderItems.Select(i => new OrderItemDto
                {
                    Id = i.Id,
                    ProductSku = i.ProductSku,
                    ProductName = i.ProductName,
                    Quantity = i.Quantity,
                    UnitPrice = i.UnitPrice
                }).ToList()
            };
        }
    }
}

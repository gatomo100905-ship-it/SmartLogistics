using AutoMapper;
using SmartLogistics.Application.Commands;
using SmartLogistics.Application.DTOs;
using SmartLogistics.Domain.Entities.Order;

namespace SmartLogistics.Application.Mappings
{
    public class OrderMappingProfile : Profile
    {
        public OrderMappingProfile()
        {
            CreateMap<Order, OrderDto>();
            CreateMap<OrderItem, OrderItemDto>();
            CreateMap<CreateOrderCommand, Order>();
            CreateMap<CreateOrderItemDto, OrderItem>();
        }
    }
}

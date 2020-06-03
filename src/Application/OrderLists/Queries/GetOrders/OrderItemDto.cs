using AutoMapper;
using Sanoma.Application.Common.Mappings;
using Sanoma.Domain.Entities;

namespace Sanoma.Application.OrderLists.Queries.GetOrders
{
    public class OrderItemDto : IMapFrom<OrderItem>
    {
        public int Id { get; set; }

        public int ListId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<OrderItem, OrderItemDto>();
        }
    }
}

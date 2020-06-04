using AutoMapper;
using Sanoma.Application.Common.Mappings;
using Sanoma.Domain.Entities;

namespace Sanoma.Application.Orders.Queries.GetOrders
{
    public class OrderDto : IMapFrom<Order>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Order, OrderDto>();
        }
    }
}

using Sanoma.Application.Common.Mappings;
using Sanoma.Domain.Entities;
using System.Collections.Generic;

namespace Sanoma.Application.OrderLists.Queries.GetOrders
{
    public class OrderListDto : IMapFrom<OrderList>
{
    public OrderListDto()
    {
        Items = new List<OrderItemDto>();
    }

    public int Id { get; set; }

    public string Title { get; set; }

    public IList<OrderItemDto> Items { get; set; }
}
}

using Sanoma.Domain.Common;
using System.Collections.Generic;

namespace Sanoma.Domain.Entities
{
    public class OrderList : AuditableEntity
    {
        public OrderList()
        {
            Items = new List<OrderItem>();
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public string Colour { get; set; }

        public IList<OrderItem> Items { get; set; }
    }
}

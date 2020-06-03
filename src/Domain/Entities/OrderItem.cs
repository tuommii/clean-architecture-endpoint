using Sanoma.Domain.Common;

namespace Sanoma.Domain.Entities
{
    public class OrderItem : AuditableEntity
    {
        public int Id { get; set; }

		public int ListId { get; set; }

		public string Name { get; set; }

		public float Price { get; set; }

		public OrderList List { get; set; }

    }
}

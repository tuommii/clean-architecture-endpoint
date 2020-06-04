using System;
using System.Collections.Generic;
using Sanoma.Domain.Common;

namespace Sanoma.Domain.Entities
{
    public class Order : AuditableEntity
    {

		public Order() {
			Orders = new HashSet<Order>();
		}
        public int Id { get; set; }

		public string Name { get; set;
		}
		public string EmailAddress { get; set; }

		public DateTime? SubmitDate { get; set; }

		public decimal TotalAmount { get; set; }

		public ICollection<Order> Orders { get; private set; }
    }
}

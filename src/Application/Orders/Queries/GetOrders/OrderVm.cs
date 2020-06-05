using System;

namespace Sanoma.Application.Orders.Queries.GetOrders
{
    public class OrderVm
    {
		public int Id { get; set; }

		public string Name { get; set;
		}
		public string EmailAddress { get; set; }

		public DateTime? SubmitDate { get; set; }

		public decimal TotalAmount { get; set; }

		// public bool WillCall { get; set; }

    }
}

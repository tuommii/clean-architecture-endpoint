using System;
using System.Collections.Generic;
using Sanoma.Domain.Common;

namespace Sanoma.Domain.Entities
{
    public class Order : AuditableEntity
    {
        public int Id { get; set; }

		public string Name { get; set;
		}
		public string EmailAddress { get; set; }

		public DateTime? SubmitDate { get; set; }

		public double TotalAmount { get; set; }

		public bool WillCall { get; set; }
    }
}

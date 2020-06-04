using System;
using Sanoma.Application.Common.Interfaces;
using Sanoma.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Sanoma.Application.Orders.Commands
{
    public class CreateOrderCommand : IRequest<int>
    {
		public string Name { get; set; }
		public string EmailAddress { get; set; }

		public DateTime? SubmitDate { get; set; }

		public decimal TotalAmount { get; set; }

		public bool WillCall { get; set; }

    }

	public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, int>
	{
	    private readonly IApplicationDbContext _context;

        public CreateOrderCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var entity = new Order
            {
				Name = request.Name,
				EmailAddress = request.EmailAddress,
				SubmitDate = request.SubmitDate,
				TotalAmount = request.TotalAmount,
				WillCall = request.WillCall
            };

            _context.Orders.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return entity.Id;
        }
	}
}

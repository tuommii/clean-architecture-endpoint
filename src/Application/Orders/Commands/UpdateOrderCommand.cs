using System;
using Sanoma.Application.Common.Interfaces;
using Sanoma.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Sanoma.Application.Common.Exceptions;


namespace Sanoma.Application.Orders.Commands
{
	public class UpdateOrderCommand : IRequest
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string EmailAddress { get; set; }

		public DateTime? SubmitDate { get; set; }

		public decimal TotalAmount { get; set; }

		public bool WillCall { get; set; }

	}

	public class UpdateOrderCommandHandler : IRequestHandler<UpdateOrderCommand>
	{
		private readonly IApplicationDbContext _context;

		public UpdateOrderCommandHandler(IApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<Unit> Handle(UpdateOrderCommand request, CancellationToken cancellationToken)
		{
			var order = await _context.Orders.FindAsync(request.Id);

			if (order == null)
            {
                throw new NotFoundException(nameof(Order), request.Id);
            }

			order.Name = request.Name;
			order.EmailAddress = request.EmailAddress;
			order.TotalAmount = request.TotalAmount;
			order.WillCall = request.WillCall;
			order.SubmitDate = request.SubmitDate;

			await _context.SaveChangesAsync(cancellationToken);

			return Unit.Value;
		}
	}
}

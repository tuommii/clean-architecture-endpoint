using System;
using Sanoma.Application.Common.Interfaces;
using Sanoma.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Sanoma.Application.Common.Exceptions;


namespace Sanoma.Application.Orders.Commands
{
	public class DeleteOrderCommand : IRequest
	{
		public int Id { get; set; }
	}

	public class DeleteOrderCommandHandler : IRequestHandler<DeleteOrderCommand>
	{
		private readonly IApplicationDbContext _context;

		public DeleteOrderCommandHandler(IApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<Unit> Handle(DeleteOrderCommand request, CancellationToken cancellationToken)
		{
			var order = await _context.Orders.FindAsync(request.Id);

			if (order == null)
            {
                throw new NotFoundException(nameof(Order), request.Id);
            }

			_context.Orders.Remove(order);

			await _context.SaveChangesAsync(cancellationToken);

			return Unit.Value;
		}
	}
}

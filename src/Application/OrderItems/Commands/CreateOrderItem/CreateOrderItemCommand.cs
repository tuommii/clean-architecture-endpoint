using Sanoma.Application.Common.Interfaces;
using Sanoma.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Sanoma.Application.OrderItems.Commands.CreateOrderItem
{
    public class CreateOrderItemCommand : IRequest<int>
    {
        public int ListId { get; set; }

        public string Name { get; set; }
    }

    public class CreateOrderItemCommandHandler : IRequestHandler<CreateOrderItemCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public CreateOrderItemCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateOrderItemCommand request, CancellationToken cancellationToken)
        {
            var entity = new OrderItem
            {
                ListId = request.ListId,
                Name = request.Name,
                Price = 0
            };

            _context.OrderItems.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return entity.Id;
        }
    }
}

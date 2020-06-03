using Sanoma.Application.Common.Interfaces;
using Sanoma.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Sanoma.Application.OrderLists.Commands.CreateOrderList
{
    public partial class CreateOrderListCommand : IRequest<int>
    {
        public string Title { get; set; }
    }

    public class CreateOrderListCommandHandler : IRequestHandler<CreateOrderListCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public CreateOrderListCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateOrderListCommand request, CancellationToken cancellationToken)
        {
            var entity = new OrderList();

            entity.Title = request.Title;

            _context.OrderLists.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return entity.Id;
        }
    }
}

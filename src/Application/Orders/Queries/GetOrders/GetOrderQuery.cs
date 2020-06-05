using AutoMapper;
using AutoMapper.QueryableExtensions;
using Sanoma.Application.Common.Exceptions;
using Sanoma.Application.Common.Interfaces;
using MediatR;
using Sanoma.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Sanoma.Application.Orders.Queries.GetOrders
{
    public class GetOrderQuery : IRequest<OrderDto>
    {
		public int Id { get; set; }
    }

	public class GetOrderQueryHandler : IRequestHandler<GetOrderQuery, OrderDto>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetOrderQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<OrderDto> Handle(GetOrderQuery request, CancellationToken cancellationToken)
        {
			var order = await _context.Orders.FindAsync(request.Id);

			if (order == null)
            {
                throw new NotFoundException(nameof(Order), request.Id);
            }

			return _mapper.Map<OrderDto>(order);
        }
    }
}

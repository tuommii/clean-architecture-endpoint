using AutoMapper;
using AutoMapper.QueryableExtensions;
using Sanoma.Application.Common.Interfaces;
using Sanoma.Domain.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Sanoma.Application.Orders.Queries.GetOrders
{
    public class GetOrdersQuery : IRequest<OrdersVm>
    {
    }

	public class GetOrdersQueryHandler : IRequestHandler<GetOrdersQuery, OrdersVm>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetOrdersQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<OrdersVm> Handle(GetOrdersQuery request, CancellationToken cancellationToken)
        {
			return new OrdersVm
			{
				Lists = await _context.Orders
					.ProjectTo<OrderDto>(_mapper.ConfigurationProvider)
					.OrderBy(o => o.Name)
					.ToListAsync(cancellationToken)
			};
        }
    }
}

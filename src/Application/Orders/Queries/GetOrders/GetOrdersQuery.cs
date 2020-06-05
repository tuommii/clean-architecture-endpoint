using AutoMapper;
using AutoMapper.QueryableExtensions;
using Sanoma.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;

namespace Sanoma.Application.Orders.Queries.GetOrders
{
    public class GetOrdersQuery : IRequest<IList>
    {
    }

	public class GetOrdersQueryHandler : IRequestHandler<GetOrdersQuery, IList>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetOrdersQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IList> Handle(GetOrdersQuery request, CancellationToken cancellationToken)
        {
			// return new IList
			// {
				return await _context.Orders
					.ProjectTo<OrderDto>(_mapper.ConfigurationProvider)
					.OrderBy(o => o.SubmitDate)
					.ToListAsync(cancellationToken);
			// };
        }
    }
}

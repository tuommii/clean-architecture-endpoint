using MediatR;

namespace Sanoma.Application.Orders.Commands
{
    public class CreateOrderCommand : IRequest<int>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}

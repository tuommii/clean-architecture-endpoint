using Sanoma.Application.Orders.Queries.GetOrders;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Sanoma.Application.Orders.Commands;
using System.Collections.Generic;

namespace Sanoma.WebUI.Controllers
{
    public class OrdersController : ApiController
    {
        [HttpGet]
        public async Task<ActionResult<IList<OrderDto>>> GetAll()
        {
			var vm = await Mediator.Send(new GetOrdersQuery());
			return base.Ok(vm);
        }

		[HttpGet("{id}")]
        public async Task<ActionResult<OrderDto>> GetById(int id)
        {
			var vm = await Mediator.Send(new GetOrderQuery { Id = id});
			return base.Ok(vm);
        }

		[HttpPost]
		public async Task<ActionResult<int>> Create(CreateOrderCommand command)
		{
			return await Mediator.Send(command);
		}

		[HttpPut("{id}")]
		public async Task<ActionResult> Update(int id, UpdateOrderCommand command)
		{
			if (id != command.Id)
			{
				return BadRequest();
			}
			await Mediator.Send(command);
			return NoContent();
		}

		[HttpDelete("{id}")]
		public async Task<ActionResult> Delete(int id)
		{
			await Mediator.Send(new DeleteOrderCommand { Id = id });
			return NoContent();
		}
	}
}

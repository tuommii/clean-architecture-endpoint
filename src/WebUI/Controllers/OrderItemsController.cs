using Sanoma.Application.OrderItems.Commands.CreateOrderItem;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Sanoma.WebUI.Controllers
{
    public class OrderItemsController : ApiController
    {
        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateOrderItemCommand command)
        {
            return await Mediator.Send(command);
        }
	}

    //     [HttpPut("{id}")]
    //     public async Task<ActionResult> Update(int id, UpdateOrderItemCommand command)
    //     {
    //         if (id != command.Id)
    //         {
    //             return BadRequest();
    //         }

    //         await Mediator.Send(command);

    //         return NoContent();
    //     }

    //     [HttpPut("[action]")]
    //     public async Task<ActionResult> UpdateItemDetails(int id, UpdateOrderItemDetailCommand command)
    //     {
    //         if (id != command.Id)
    //         {
    //             return BadRequest();
    //         }

    //         await Mediator.Send(command);

    //         return NoContent();
    //     }

    //     [HttpDelete("{id}")]
    //     public async Task<ActionResult> Delete(int id)
    //     {
    //         await Mediator.Send(new DeleteOrderItemCommand { Id = id });

    //         return NoContent();
    //     }
    // }
}

using Sanoma.Application.OrderLists.Commands.CreateOrderList;
// using Sanoma.Application.OrderLists.Commands.DeleteOrderList;
// using Sanoma.Application.OrderLists.Commands.UpdateOrderList;
// using Sanoma.Application.OrderLists.Queries.ExportOrders;
// using Sanoma.Application.OrderLists.Queries.GetOrders;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Sanoma.WebUI.Controllers
{
    public class OrderListsController : ApiController
    {
        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateOrderListCommand command)
        {
            return await Mediator.Send(command);
        }

        // [HttpGet]
        // public async Task<ActionResult<OrdersVm>> Get()
        // {
        //     return await Mediator.Send(new GetOrdersQuery());
        // }

        // [HttpGet("{id}")]
        // public async Task<FileResult> Get(int id)
        // {
        //     var vm = await Mediator.Send(new ExportOrdersQuery { ListId = id });

        //     return File(vm.Content, vm.ContentType, vm.FileName);
        // }


        // [HttpPut("{id}")]
        // public async Task<ActionResult> Update(int id, UpdateOrderListCommand command)
        // {
        //     if (id != command.Id)
        //     {
        //         return BadRequest();
        //     }

        //     await Mediator.Send(command);

        //     return NoContent();
        // }

        // [HttpDelete("{id}")]
        // public async Task<ActionResult> Delete(int id)
        // {
        //     await Mediator.Send(new DeleteOrderListCommand { Id = id });

        //     return NoContent();
        // }
    }
}

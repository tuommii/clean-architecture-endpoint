using Sanoma.Application.Common.Exceptions;
using Sanoma.Application.Orders.Commands;
using Sanoma.Domain.Entities;
using FluentAssertions;
using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace Sanoma.Application.IntegrationTests.TodoItems.Commands
{
    using static Testing;

    public class CreateOrderTests : TestBase
    {
        [Test]
        public void ShouldRequireMinimumFields()
        {
            var command = new CreateOrderCommand();

            FluentActions.Invoking(() =>
                SendAsync(command)).Should().Throw<ValidationException>();
        }

        [Test]
        public async Task ShouldCreateTodoItem()
        {
            var userId = await RunAsDefaultUserAsync();
			var command =  new CreateOrderCommand
			{
				Name = "Order 1",
				EmailAddress = "a@b.fi",
			};

			var itemId = await SendAsync(command);
			var item = await FindAsync<Order>(itemId);

			item.Should().NotBeNull();
            // {
            //     Title = "New List"
            // });

            // var command = new CreateOrderCommand
            // {
            //     ListId = listId,
            //     Title = "Tasks"
            // };

            // var itemId = await SendAsync(command);

            // var item = await FindAsync<TodoItem>(itemId);

            // item.Should().NotBeNull();
            // item.ListId.Should().Be(command.ListId);
            // item.Title.Should().Be(command.Title);
            // item.CreatedBy.Should().Be(userId);
            // item.Created.Should().BeCloseTo(DateTime.Now, 10000);
            // item.LastModifiedBy.Should().BeNull();
            // item.LastModified.Should().BeNull();
        }
    }
}

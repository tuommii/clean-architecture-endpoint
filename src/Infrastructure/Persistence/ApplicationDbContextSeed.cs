using Sanoma.Domain.Entities;
using Sanoma.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Threading.Tasks;

namespace Sanoma.Infrastructure.Persistence
{
    public static class ApplicationDbContextSeed
    {
        public static async Task SeedDefaultUserAsync(UserManager<ApplicationUser> userManager)
        {
            var defaultUser = new ApplicationUser { UserName = "administrator@localhost", Email = "administrator@localhost" };

            if (userManager.Users.All(u => u.UserName != defaultUser.UserName))
            {
                await userManager.CreateAsync(defaultUser, "Administrator1!");
            }
        }

        public static async Task SeedSampleDataAsync(ApplicationDbContext context)
        {
			if (!context.Orders.Any())
			{
				context.Orders.Add(new Order { Name = "Order 1" });
				context.Orders.Add(new Order { Name = "Order 2" });
				context.Orders.Add(new Order { Name = "Order 3" });
				await context.SaveChangesAsync();
			}
        }
    }
}

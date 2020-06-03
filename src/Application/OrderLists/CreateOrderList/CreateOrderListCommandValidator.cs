using Sanoma.Application.Common.Interfaces;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Sanoma.Application.OrderLists.Commands.CreateOrderList
{
    public class CreateOrderListCommandValidator : AbstractValidator<CreateOrderListCommand>
    {
        private readonly IApplicationDbContext _context;

        public CreateOrderListCommandValidator(IApplicationDbContext context)
        {
            _context = context;

            RuleFor(v => v.Title)
                .NotEmpty().WithMessage("Title is required.")
                .MaximumLength(200).WithMessage("Title must not exceed 200 characters.")
                .MustAsync(BeUniqueTitle).WithMessage("The specified title already exists.");
        }

        public async Task<bool> BeUniqueTitle(string title, CancellationToken cancellationToken)
        {
            return await _context.OrderLists
                .AllAsync(l => l.Title != title);
        }
    }
}

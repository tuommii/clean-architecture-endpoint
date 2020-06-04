using System;
using FluentValidation;

namespace Sanoma.Application.Orders.Commands
{
    public class CreateOrderCommandValidator : AbstractValidator<CreateOrderCommand>
    {
        public CreateOrderCommandValidator()
        {
            RuleFor(o => o.Name)
                .MaximumLength(300)
                .NotEmpty();
			// Example, not a real validation
            RuleFor(o => o.EmailAddress)
                .Length(4, 100)
                .NotEmpty();
			RuleFor(o => o.TotalAmount)
				.ExclusiveBetween(-922337203685478, 922337203685478);
        }
    }
}

using FluentValidation;

namespace Sanoma.Application.Orders.Commands
{
    public class UpdateOrderCommandValidator : AbstractValidator<UpdateOrderCommand>
    {
        public UpdateOrderCommandValidator()
        {
            RuleFor(o => o.Name)
                .MaximumLength(300)
                .NotEmpty();

			// example, is not enough to validate email
            RuleFor(o => o.EmailAddress)
                .Length(4, 100)
                .NotEmpty();

			RuleFor(o => o.TotalAmount)
				.ExclusiveBetween(-922337203685478, 922337203685478);
        }
    }
}

using FluentValidation;
using SmartLogistics.Application.Commands;

namespace SmartLogistics.Application.Validators
{
    public class CreateOrderCommandValidator : AbstractValidator<CreateOrderCommand>
    {
        public CreateOrderCommandValidator()
        {
            RuleFor(v => v.OrderNumber)
                .NotEmpty().WithMessage("MĂ£ Ä‘Æ¡n hĂ ng khĂ´ng Ä‘Æ°á»£c Ä‘á»ƒ trá»‘ng.")
                .MaximumLength(50).WithMessage("MĂ£ Ä‘Æ¡n hĂ ng khĂ´ng quĂ¡ 50 kĂ½ tá»±.");

            RuleFor(v => v.CustomerId)
                .NotEmpty().WithMessage("MĂ£ khĂ¡ch hĂ ng khĂ´ng Ä‘Æ°á»£c Ä‘á»ƒ trá»‘ng.");

            RuleFor(v => v.Items)
                .NotEmpty().WithMessage("ÄÆ¡n hĂ ng pháº£i chá»©a Ă­t nháº¥t má»™t sáº£n pháº©m.");

            RuleForEach(v => v.Items).SetValidator(new CreateOrderItemDtoValidator());
        }
    }

    public class CreateOrderItemDtoValidator : AbstractValidator<CreateOrderItemDto>
    {
        public CreateOrderItemDtoValidator()
        {
            RuleFor(v => v.ProductSku)
                .NotEmpty().WithMessage("MĂ£ SKU sáº£n pháº©m khĂ´ng Ä‘Æ°á»£c trá»‘ng.");

            RuleFor(v => v.Quantity)
                .GreaterThan(0).WithMessage("Sá»‘ lÆ°á»£ng pháº£i lá»›n hÆ¡n 0.");

            RuleFor(v => v.UnitPrice)
                .GreaterThan(0).WithMessage("ÄÆ¡n giĂ¡ pháº£i lá»›n hÆ¡n 0.");
        }
    }
}

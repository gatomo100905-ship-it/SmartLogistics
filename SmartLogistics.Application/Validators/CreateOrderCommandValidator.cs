using FluentValidation;
using SmartLogistics.Application.Commands;

namespace SmartLogistics.Application.Validators
{
    public class CreateOrderCommandValidator : AbstractValidator<CreateOrderCommand>
    {
        public CreateOrderCommandValidator()
        {
            RuleFor(v => v.OrderNumber)
                .NotEmpty().WithMessage("Mã đơn hàng không được để trống.")
                .MaximumLength(50).WithMessage("Mã đơn hàng không quá 50 ký tự.");

            RuleFor(v => v.CustomerId)
                .NotEmpty().WithMessage("Mã khách hàng không được để trống.");

            RuleFor(v => v.Items)
                .NotEmpty().WithMessage("Đơn hàng phải chứa ít nhất một sản phẩm.");

            RuleForEach(v => v.Items).SetValidator(new CreateOrderItemDtoValidator());
        }
    }

    public class CreateOrderItemDtoValidator : AbstractValidator<CreateOrderItemDto>
    {
        public CreateOrderItemDtoValidator()
        {
            RuleFor(v => v.ProductSku)
                .NotEmpty().WithMessage("Mã SKU sản phẩm không được trống.");

            RuleFor(v => v.Quantity)
                .GreaterThan(0).WithMessage("Số lượng phải lớn hơn 0.");

            RuleFor(v => v.UnitPrice)
                .GreaterThan(0).WithMessage("Đơn giá phải lớn hơn 0.");
        }
    }
}

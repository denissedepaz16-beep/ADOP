using ADOP.BusinessLogic.DTOs;
using MediatR;

namespace ADOP.BusinessLogic.UseCases.Products.Commands.UpdateProduct
{
    public record UpdateProductCommand(UpdateProductRequest Request) : IRequest<long>;
}

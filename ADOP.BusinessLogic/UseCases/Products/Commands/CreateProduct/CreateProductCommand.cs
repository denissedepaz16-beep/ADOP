using ADOP.BusinessLogic.DTOs;
using MediatR;

namespace ADOP.BusinessLogic.UseCases.Products.Commands.CreateProduct;

public record CreateProductCommand(CreateProductRequest Request) : IRequest<long>;

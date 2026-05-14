using ADOP.BusinessLogic.DTOs;
using MediatR;

namespace ADOP.BusinessLogic.UseCases.Products.Queries.GetProduct;

public record GetProductQuery(long Id) : IRequest<ProductByIdResponse>;

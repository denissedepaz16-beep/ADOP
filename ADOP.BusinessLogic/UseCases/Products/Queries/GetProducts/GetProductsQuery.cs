using ADOP.BusinessLogic.DTOs;
using MediatR;

namespace ADOP.BusinessLogic.UseCases.Products.Queries.GetProducts;

public record GetProductsQuery : IRequest<List<ProductoResponse>>;

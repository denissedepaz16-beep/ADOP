using ADOP.BusinessLogic.DTOs;
using MediatR;

namespace ADOP.BusinessLogic.UseCases.Brands.Queries.GetBrands;

public record GetBrandsQuery() : IRequest<List<BrandResponse>>;

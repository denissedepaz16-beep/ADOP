using ADOP.BusinessLogic.DTOs;
using MediatR;

namespace ADOP.BusinessLogic.UseCases.Brands.Queries.GetBrand;

public record GetBrandQuery(int brandId) : IRequest<BrandResponse>;


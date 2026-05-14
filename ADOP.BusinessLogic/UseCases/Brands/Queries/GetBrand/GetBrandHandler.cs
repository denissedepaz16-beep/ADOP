using ADOP.BusinessLogic.DTOs;
using ADOP.DataAccess.Interfaces;
using ADOP.Entities;
using Mapster;
using MediatR;

namespace ADOP.BusinessLogic.UseCases.Brands.Queries.GetBrand;

internal sealed class GetBrandHandler(IEfRepository<Designer> _repository) : IRequestHandler<GetBrandQuery, BrandResponse>
{
    public async Task<BrandResponse> Handle(GetBrandQuery query, CancellationToken cancellationToken)
    {
        var brand = await _repository.GetByIdAsync(query.brandId, cancellationToken);

        if (brand == null)
        {
            return new BrandResponse();
        }

        return brand.Adapt<BrandResponse>();
    }
}

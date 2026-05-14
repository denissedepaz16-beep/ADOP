using ADOP.BusinessLogic.DTOs;
using ADOP.BusinessLogic.UseCases.Brands.Queries.GetBrands;
using ADOP.DataAccess.Interfaces;
using ADOP.Entities;
using Mapster;
using MediatR;

namespace ADOP.BusinessLogic.UseCases.Brands.Queries.GetBrands;

internal sealed class GetBrandsHandler(IEfRepository<Designer> _repository) : IRequestHandler<GetBrandsQuery, List<BrandResponse>>
{
    public async Task<List<BrandResponse>> Handle(GetBrandsQuery query, CancellationToken cancellationToken)
    {
        var brands = await _repository.ListAsync(cancellationToken);

        if (brands == null || !brands.Any())
        {
            return new List<BrandResponse>();
        }

        return brands.Adapt<List<BrandResponse>>();

    }
}

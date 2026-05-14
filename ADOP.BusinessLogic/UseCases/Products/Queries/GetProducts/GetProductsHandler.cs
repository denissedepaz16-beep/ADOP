using ADOP.BusinessLogic.DTOs;
using ADOP.BusinessLogic.UseCases.Products.Specifications;
using ADOP.DataAccess.Interfaces;
using ADOP.Entities;
using Mapster;
using MediatR;

namespace ADOP.BusinessLogic.UseCases.Products.Queries.GetProducts
{
    internal sealed class GetProductsHandler(IEfRepository<Garment> _repository) : IRequestHandler<GetProductsQuery, List<ProductoResponse>>
    {
        public async Task<List<ProductoResponse>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            var products = await _repository.ListAsync(new GetProductWithBrandSpec(), cancellationToken);

            if (products == null && !products.Any())
            {
                return new List<ProductoResponse>();
            }

            return products.Adapt<List<ProductoResponse>>();
        }
    }
}

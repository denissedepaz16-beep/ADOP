using ADOP.BusinessLogic.DTOs;
using ADOP.BusinessLogic.UseCases.Products.Queries.GetProduct;
using ADOP.DataAccess.Interfaces;
using ADOP.Entities;
using Mapster;
using MediatR;

namespace ADOP.BusinessLogic.UseCases.Products.Queries.GetProduct
{
    internal sealed class GetProductHandler(IEfRepository<Garment> _repository) : IRequestHandler<GetProductQuery, ProductByIdResponse>
    {
        public async Task<ProductByIdResponse> Handle(GetProductQuery query, CancellationToken cancellationToken)
        {
            var product = await _repository.GetByIdAsync(query.Id, cancellationToken);

            if (product is null)
            {
                return new ProductByIdResponse();
            }

            return product.Adapt<ProductByIdResponse>();
        }
    }
}

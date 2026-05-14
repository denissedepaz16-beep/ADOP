using ADOP.DataAccess.Interfaces;
using ADOP.Entities;
using Mapster;
using MediatR;

namespace ADOP.BusinessLogic.UseCases.Products.Commands.CreateProduct
{
    internal sealed class CreateProductHandler(IEfRepository<Garment> _repository)
        : IRequestHandler<CreateProductCommand, long>
    {
        public async Task<long> Handle(CreateProductCommand command, CancellationToken cancellationToken)
        {
            try
            {
                var newProduct = command.Request.Adapt<Garment>();

                var createdProduct = await _repository.AddAsync(newProduct, cancellationToken);

                return createdProduct.Id;
            }
            catch
            {
                throw;
            }
        }

    }
}

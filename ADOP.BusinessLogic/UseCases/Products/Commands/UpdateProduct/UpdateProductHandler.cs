using ADOP.DataAccess.Interfaces;
using ADOP.Entities;
using Mapster;
using MediatR;

namespace ADOP.BusinessLogic.UseCases.Products.Commands.UpdateProduct
{
    internal sealed class UpdateProductHandler(IEfRepository<Garment> _repository)
        : IRequestHandler<UpdateProductCommand, long>
    {
        public async Task<long> Handle(UpdateProductCommand command, CancellationToken cancellationToken)
        {
            try
            {
                var existingProduct = await _repository.GetByIdAsync((int)command.Request.Id, cancellationToken);
                if (existingProduct == null) return 0;

                existingProduct = command.Request.Adapt(existingProduct);
                await _repository.UpdateAsync(existingProduct, cancellationToken);

                return existingProduct.Id;
            }
            catch (Exception)
            {
                return 0;
                throw;
            }
        }
    }
}

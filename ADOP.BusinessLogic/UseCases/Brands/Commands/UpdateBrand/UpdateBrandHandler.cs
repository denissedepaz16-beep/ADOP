using ADOP.DataAccess.Interfaces;
using ADOP.Entities;
using Mapster;
using MediatR;

namespace ADOP.BusinessLogic.UseCases.Brands.Commads.UpdateBrand;

internal sealed class UpdateBrandHandler(IEfRepository<Designer> _repository) : IRequestHandler<UpdateBrandCommand, int>
{
    public async Task<int> Handle(UpdateBrandCommand command, CancellationToken cancellationToken)
    {
        try
        {
            var existingDesigner = await _repository.GetByIdAsync(command.Request.Id);

            if (existingDesigner is null) return 0;

            existingDesigner = command.Request.Adapt(existingDesigner);

            await _repository.UpdateAsync(existingDesigner, cancellationToken);

            return existingDesigner.Id;
        }
        catch (Exception)
        {
            return 0;
            throw;
        }
    }
}

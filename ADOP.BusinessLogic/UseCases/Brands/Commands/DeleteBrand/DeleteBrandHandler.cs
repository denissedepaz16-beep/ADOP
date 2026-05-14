using ADOP.BusinessLogic.UseCases.Brands.Commands.DeleteBrand;
using ADOP.DataAccess.Interfaces;
using ADOP.Entities;
using MediatR;

namespace ADOP.BusinessLogic.UseCases.Brands.Commands.DeleteBrand;

internal sealed class DeleteBrandHandler(IEfRepository<Designer> _repository) : IRequestHandler<DeleteBrandCommand, int>
{
    public async Task<int> Handle(DeleteBrandCommand command, CancellationToken cancellationToken)
    {
        var existingBrand = await _repository.GetByIdAsync(command.brandId);

        if (existingBrand is null) return 0;

        await _repository.DeleteAsync(existingBrand, cancellationToken);

        return existingBrand.Id;
    }
}

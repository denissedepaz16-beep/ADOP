using ADOP.BusinessLogic.UseCases.Brands.Commads.CreateBrand;
using ADOP.DataAccess.Interfaces;
using ADOP.Entities;
using Mapster;
using MediatR;

namespace ADOP.BusinessLogic.UseCases.Brands.Commands.CreateBrand;

internal sealed class CreateBrandHandler(IEfRepository<Designer> _repository) : IRequestHandler<CreateBrandCommand, int>
{
    public async Task<int> Handle(CreateBrandCommand command, CancellationToken cancellationToken)
    {
        try
        {
            var newDesigner = command.Request.Adapt<Designer>();

            var createDesigner = await _repository.AddAsync(newDesigner, cancellationToken);

            return createDesigner.Id;
        }
        catch (Exception)
        {
            return 0;
            throw;
        }
    }
}
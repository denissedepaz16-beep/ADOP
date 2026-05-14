using ADOP.BusinessLogic.DTOs;
using ADOP.BusinessLogic.UseCases.Users.Queries.GetRoles;
using ADOP.DataAccess.Interfaces;
using ADOP.Entities;
using Mapster;
using MediatR;

namespace ADOP.BusinessLogic.UseCases.Users.Queries.GetRoles;

internal sealed class GetRolesHandler(IEfRepository<Role> _repository)
    : IRequestHandler<GetRolesQuery, List<RoleResponse>>
{
    public async Task<List<RoleResponse>> Handle(GetRolesQuery query, CancellationToken cancellationToken)
    {
        var roles = await _repository.ListAsync(cancellationToken);

        if (roles == null || !roles.Any())
        {
            return new List<RoleResponse>();
        }

        return roles.Adapt<List<RoleResponse>>();
    }
}

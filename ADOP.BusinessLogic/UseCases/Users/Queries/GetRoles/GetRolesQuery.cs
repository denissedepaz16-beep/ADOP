using ADOP.BusinessLogic.DTOs;
using MediatR;

namespace ADOP.BusinessLogic.UseCases.Users.Queries.GetRoles;

public record GetRolesQuery : IRequest<List<RoleResponse>>;
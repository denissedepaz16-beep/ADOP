using ADOP.BusinessLogic.DTOs;
using MediatR;

namespace ADOP.BusinessLogic.UseCases.Users.Queries.GetUsers;

public record GetUsersQuery : IRequest<List<UserResponse>>;

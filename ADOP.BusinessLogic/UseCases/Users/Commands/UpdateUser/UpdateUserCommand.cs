using ADOP.BusinessLogic.DTOs;
using MediatR;

namespace ADOP.BusinessLogic.UseCases.Users.Commands.UpdateUser;

public record UpdateUserCommand(UpdateUserRequest Request) : IRequest<int>;

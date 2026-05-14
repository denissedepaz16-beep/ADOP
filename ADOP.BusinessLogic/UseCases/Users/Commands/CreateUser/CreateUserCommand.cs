using ADOP.BusinessLogic.DTOs;
using MediatR;

namespace ADOP.BusinessLogic.UseCases.Users.Commands.CreateUser;

public record CreateUserCommand(CreateUserRequest Request) : IRequest<int>;

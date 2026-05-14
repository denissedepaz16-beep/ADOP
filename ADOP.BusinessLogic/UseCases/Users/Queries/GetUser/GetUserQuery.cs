using ADOP.BusinessLogic.DTOs;
using MediatR;

namespace ADOP.BusinessLogic.UseCases.Users.Queries.GetUser;

public record GetUserQuery(int userId) : IRequest<UserByIdResponse>;


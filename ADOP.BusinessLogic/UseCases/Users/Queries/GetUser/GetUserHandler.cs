using ADOP.BusinessLogic.DTOs;
using ADOP.DataAccess.Interfaces;
using ADOP.Entities;
using Mapster;
using MediatR;

namespace ADOP.BusinessLogic.UseCases.Users.Queries.GetUser;

internal sealed class GetUserHandler(IEfRepository<User> _repository)
        : IRequestHandler<GetUserQuery, UserByIdResponse>
{
    public async Task<UserByIdResponse> Handle(GetUserQuery query, CancellationToken cancellationToken)
    {
        var user = await _repository.GetByIdAsync(query.userId, cancellationToken);

        if (user is null)
        {
            return new UserByIdResponse();
        }

        return user.Adapt<UserByIdResponse>();
    }
}
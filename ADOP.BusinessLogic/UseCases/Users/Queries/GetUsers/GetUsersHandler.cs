using ADOP.BusinessLogic.DTOs;
using ADOP.DataAccess.Interfaces;
using ADOP.Entities;
using Mapster;
using MediatR;

namespace ADOP.BusinessLogic.UseCases.Users.Queries.GetUsers;

internal sealed class GetUsersHandler(IEfRepository<User> _repository)
    : IRequestHandler<GetUsersQuery, List<UserResponse>>
{
    public async Task<List<UserResponse>> Handle(GetUsersQuery query, CancellationToken cancellationToken)
    {
        var users = await _repository.ListAsync(cancellationToken);

        if (users == null || !users.Any())
        {
            return new List<UserResponse>();
        }

        return users.Adapt<List<UserResponse>>();
    }
}

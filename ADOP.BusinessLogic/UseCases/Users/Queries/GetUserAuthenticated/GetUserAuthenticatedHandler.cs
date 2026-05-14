using ADOP.BusinessLogic.DTOs;
using ADOP.BusinessLogic.UseCases.Users.Specifications;
using ADOP.DataAccess.Interfaces;
using ADOP.Entities;
using Mapster;
using MediatR;

namespace ESFE.BusinessLogic.UseCases.Users.Queries.GetUserAuthenticated;

internal sealed class GetUserAuthenticatedHandler(IEfRepository<User> _repository)
    : IRequestHandler<GetUserAuthenticatedQuery, UserResponse>
{
    public async Task<UserResponse> Handle(GetUserAuthenticatedQuery query, CancellationToken cancellationToken)
    {
        var user = await _repository.FirstOrDefaultAsync(new GetUserAuthenticatedSpec(query.userName, query.password), cancellationToken);

        if (user is null)
        {
            return new UserResponse();
        }

        return user.Adapt<UserResponse>();
    }
}

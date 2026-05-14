using ADOP.BusinessLogic.UseCases.Users.Commands.CreateUser;
using ADOP.DataAccess.Interfaces;
using ADOP.Entities;
using Mapster;
using MediatR;

namespace ADOP.BusinessLogic.UseCases.Users.Commads.CreateUser;


internal sealed class CreateUserHandler(IEfRepository<User> _repository)
    : IRequestHandler<CreateUserCommand, int>
{
    public async Task<int> Handle(CreateUserCommand command, CancellationToken cancellationToken)
    {
        try
        {
            var newUser = command.Request.Adapt<User>();
            var createdUser = await _repository.AddAsync(newUser, cancellationToken);
            return createdUser.Id;
        }
        catch (Exception)
        {
            return 0;
            throw;
        }
    }
}
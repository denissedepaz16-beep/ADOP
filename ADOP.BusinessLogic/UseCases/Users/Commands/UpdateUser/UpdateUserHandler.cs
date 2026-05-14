using ADOP.DataAccess.Interfaces;
using ADOP.Entities;
using Mapster;
using MediatR;

namespace ADOP.BusinessLogic.UseCases.Users.Commands.UpdateUser;

internal sealed class UpdateUserHandler(IEfRepository<User> _repository)
    : IRequestHandler<UpdateUserCommand, int>
{
    public async Task<int> Handle(UpdateUserCommand command, CancellationToken cancellationToken)
    {
        try
        {
            var existingUser = await _repository.GetByIdAsync(command.Request.Id, cancellationToken);
            if (existingUser is null) return 0;

            // Mapear
            command.Request.Adapt(existingUser);

            await _repository.UpdateAsync(existingUser, cancellationToken);

            return existingUser.Id;
        }
        catch (Exception ex)
        {
            throw new Exception(
                ex.InnerException?.InnerException?.Message
                ?? ex.InnerException?.Message
                ?? ex.Message,
                ex
            );
        }
    }
}

using ADOP.Entities;
using Ardalis.Specification;

namespace ADOP.BusinessLogic.UseCases.Users.Specifications
{
    public class GetUserAuthenticatedSpec : Specification<User>
    {
        public GetUserAuthenticatedSpec(string handle, string secretHash)
        {
            Query.Where(u =>
                u.Handle == handle
                && u.SecretHash == secretHash
            );

            Query.Include(u => u.Role);
        }
    }
}
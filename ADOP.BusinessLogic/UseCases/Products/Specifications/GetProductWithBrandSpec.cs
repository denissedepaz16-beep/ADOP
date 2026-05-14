using Ardalis.Specification;
using ADOP.Entities;

namespace ADOP.BusinessLogic.UseCases.Products.Specifications
{
    public class GetProductWithBrandSpec : Specification<Garment>
    {
        public GetProductWithBrandSpec()
        {
            Query.Include(p => p.Designer);
        }
    }
}

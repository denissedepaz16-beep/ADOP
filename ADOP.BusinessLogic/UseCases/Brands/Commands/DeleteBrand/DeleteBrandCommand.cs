using MediatR;

namespace ADOP.BusinessLogic.UseCases.Brands.Commands.DeleteBrand;

public record DeleteBrandCommand(int brandId) : IRequest<int>;

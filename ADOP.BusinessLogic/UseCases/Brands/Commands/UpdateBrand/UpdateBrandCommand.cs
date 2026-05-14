using ADOP.BusinessLogic.DTOs;
using MediatR;

namespace ADOP.BusinessLogic.UseCases.Brands.Commads.UpdateBrand;

public record UpdateBrandCommand(UpdateBrandRequest Request) : IRequest<int>;

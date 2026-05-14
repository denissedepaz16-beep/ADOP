using ADOP.BusinessLogic.DTOs;
using MediatR;

namespace ADOP.BusinessLogic.UseCases.Brands.Commands.CreateBrand;

public record CreateBrandCommand(CreateBrandRequest Request) : IRequest<int>;


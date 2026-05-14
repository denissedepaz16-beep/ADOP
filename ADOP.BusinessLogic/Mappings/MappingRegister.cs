using ADOP.BusinessLogic.DTOs;
using ADOP.Entities;
using Mapster;

namespace ADOP.BusinessLogic.Mappings
{
    public class MappingRegister : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<Garment, ProductoResponse>();

            config.NewConfig<User, UserResponse>()
                .Map(ud => ud.RoleId, u => u.Role.PositionName);
        }
    }
}

using AutoMapper;
using SDUX_Camed_API_02.Entities;
using SDUX_Camed_API_02.Models;

namespace SDUX_Camed_API_02.Mapper
{
    public class ClienteMappingProfile : Profile
    {
        public ClienteMappingProfile()
        {
            CreateMap<ClienteModel, Cliente>()
                .ForMember(dest => dest.Id, opt => opt.Ignore());

            CreateMap<Cliente, ClienteModel>();
        }
    }
}

using AutoMapper;
using Krysburger.Core.DTOs;
using Krysburger.Core.InputModels;
using Krysburger.Core.OutputModels;


namespace Krysburger.BLL.Mappings
{
    public class UserMapperProfile:Profile
    {
        public UserMapperProfile() 
        {
            CreateMap<UserInputModel, UserDTO>();
            CreateMap<UserDTO, UserOutputModel>();
        }
    }
}

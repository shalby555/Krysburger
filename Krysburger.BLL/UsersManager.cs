using Krysburger.DAL;
using AutoMapper;
using Krysburger.Core.OutputModels;
using Krysburger.Core.DTOs;
using Krysburger.BLL.Mappings;
using Krysburger.Core.InputModels;

namespace Krysburger.BLL
{
    public class UsersManager
    {
        public UsersRepository UserRepository;

        private Mapper _mapper;

        public UsersManager()
        {
            UserRepository = new();

            var config = new MapperConfiguration(
                cfg => {
                    cfg.AddProfile(new UserMapperProfile());
                });
            _mapper = new(config);
        }

        public UserOutputModel? UserLogin(UserInputModel user)
        {
            var userToReturn = new UserOutputModel();

            var userDTO = UserRepository.GetUserByLogin(user.Login);

            if (userDTO is not null && userDTO.Password == user.Password)
            {
                userToReturn = _mapper.Map<UserOutputModel>(userDTO);
                return userToReturn;
            }

            return null;
        }
    }
}

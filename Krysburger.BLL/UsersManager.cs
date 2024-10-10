using Krysburger.DAL;
using AutoMapper;
using Krysburger.Core.OutputModels;
using Krysburger.Core.DTOs;
using Krysburger.BLL.Mappings;

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

        public UserOutputModel UserLogin(string login, string password)
        {
            var user = new UserOutputModel();

            var userDTO = UserRepository.GetUserByLogin(login);

            if (userDTO is not null && userDTO.Password == password)
            {
                user = _mapper.Map<UserOutputModel>(userDTO);
            }

            return user;
        }
    }
}

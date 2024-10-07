using Krysburger.Core;
using Krysburger.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Krysburger.BLL
{
    public class UsersManager
    {
        public UsersRepository UserRepository = new();

        public string UserLogin(string login, string password)
        {
            var url = "/start-page";

            var user = UserRepository.GetUserByLogin(login);

            if (user is not null && user.Password == password)
            {
                switch (user.RoleId)
                {
                    case 0:
                        url = Urls.AdminStartPage;
                        break;

                    case 1:
                        url = Urls.WaiterStartPage;
                        break;
                }
            }

            return url;
        }
    }
}

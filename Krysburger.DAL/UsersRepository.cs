using Krysburger.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krysburger.DAL
{
    public class UsersRepository
    {
        public UserDTO GetUserByLogin(string login)
        {
            //string conectionString = Options.ConnectionString;

            //using (var connection = new NpgsqlConnection(conectionString))
            //{
            //    string query = UserQueries.GetUserByIdQuery;

            //    var args = new
            //    {
            //        userId = userId
            //    };

            //    connection.Open();

            //    return connection.QuerySingle<UserDTO>(query, args);
            //}

            var user = new UserDTO{ Id = 1, Login = "ZHOPA", Password = "BOBRA", Name = "UROD", RoleId = 1 };
            return user;
        }
    }
}

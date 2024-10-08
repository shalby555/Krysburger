using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krysburger.Core.InputModels
{
    public class UserInputModel
    {

        [Required (ErrorMessage = "Пойман на ошибке!")]

        public int Id { get; set; } 

        public string Login { get; set; }

        public string Password { get; set; }

        public int Role { get; set; }
    }
}

using MyTestMVP_Project.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestMVP_Project.BL
{
    public class Authorization : IAuthorization
    {
        public  string AuthorizationPasswor (string password)
        {
            if (password == "123")
            {
                return "Вы вошли как администратор";
            }
            else
            {
                return "Я вас не  знаю";
            }
        }
    }
}

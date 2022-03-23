using MyTestMVP_Project.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestMVP_Project.ViewConsole
{
    /// <summary>
    /// основная логика консоли
    /// </summary>
    internal class MyConsole : IViewInterface
    {
        public event EventHandler EnterPassword;
        private string _password;
        public string Passwor { get => _password; }

        public void Start()
        {
            Console.WriteLine("Старт программы");
            PrintMessage("Введите пароль");
            _password =  GetString();

            if(EnterPassword != null)
            {
                EnterPassword(this,  EventArgs.Empty);
            }
        }

        private string  GetString()
        {
            var buf = Console.ReadLine();
            if (string.IsNullOrEmpty(buf))
            {
              PrintMessage("не корректный ввод - попробуйте  еще раз");
              return GetString();
            }
            return buf; ;
        }

        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}

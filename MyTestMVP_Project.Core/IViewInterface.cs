using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestMVP_Project.Core
{
    public interface IViewInterface
    {
        string Passwor { get;}
        event EventHandler EnterPassword;
        void PrintMessage (string message);
    }
}

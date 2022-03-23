using System;

namespace MyTestMVP_Project.ViewConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            try
            {
                MyConsole myConsole = new MyConsole();
                myConsole.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
    }
}
//https://github.com/frakiec89/MyTestMVP_Project.ViewConsole
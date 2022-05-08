using System;

namespace Overloading_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Authentication AUTH=new Authentication();
            string email = "ayaj123@gmail.com";
            string password = "12347";
            string mobile= "9340336471";

            AUTH.LoginUser(mobile);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Overloading_Program
{
    public class Authentication
    {
        public void LoginUser(string email, string password)
        {
            if (email == "ayaj123@gmail.com" && password == "12345")
            {
                Console.WriteLine("Login Successfully");
            }
            else
            {
                Console.WriteLine("Please Enter Correct Email and Password !!");
            }
        }
        public void LoginUser(string mobile)
        {
            if (!string.IsNullOrEmpty(mobile))
            {
                Console.WriteLine("enter your Mobile:");
                string mob= Console.ReadLine();

                // send otp to the mobile number given by users
                Console.WriteLine("otp sent to "+mob +" Number");
               
            }
            else
            {
                Console.WriteLine("Enter correct number");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.DependencyResolvers.Ninject;
using Entities.Concrete;

namespace ConsoleUI
{
    public class UserClass
    {
        private readonly IUserService _userService = InstanceFactory.GetInstance<IUserService>();
        public void UserMenu()
        {
            Console.WriteLine("\t\t\tWelcome User Panel");
            Console.WriteLine("1- Login");
            Console.WriteLine("2- Register");
            Console.WriteLine("0- Exit");

            Console.Write("please choose (0-2): ");
            var choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    Console.Clear();
                    Login();
                    break;
                case 2:
                    Console.Clear();
                    Register();
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }

        private void Login()
        {
            Console.WriteLine("\t\t\tLogin");
            Console.Write("Username : ");
            var userName = Console.ReadLine();
            Console.Write("Password : ");
            var password = Console.ReadLine();


        }

        private void Register()
        {

        }
    }
}

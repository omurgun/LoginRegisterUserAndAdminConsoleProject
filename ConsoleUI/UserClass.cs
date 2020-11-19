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
            Console.WriteLine("3- Back To Main Menu");
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
                case 3:
                    Console.Clear();
                    Program.MainMenu();
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
            var user = _userService.GetUserByUserNameAndPassword(userName, password);
            if (user != null)
            {
                Console.WriteLine("Logging in please wait...");
            }
            else
            {
                Console.WriteLine("username or password is incorrect");
            }


        }
        private void Register()
        {
            Console.WriteLine("\t\t\tRegister");
            Console.Write("First Name : ");
            var firstName = Console.ReadLine();
            Console.Write("Last Name : ");
            var lastName = Console.ReadLine();
            Console.Write("User Name : ");
            var userName = Console.ReadLine();
            Console.Write("User Password : ");
            var userPassword = Console.ReadLine();
            Console.Clear();
            var user = GetUserByUserName(userName);
            if (user == null)
            {
                var addedUser = RegisterUser(new User
                {
                    UserFirstName = firstName,
                    UserLastName = lastName,
                    UserName = userName,
                    UserPassword = userPassword
                });
                if (addedUser != null)
                {
                    Console.WriteLine("User added!");
                }
                else
                {
                    Console.WriteLine("Could not add user!");
                }

            }
            else
            {
                Console.WriteLine("User already exists!");
            }
        }

        private User RegisterUser(User user)
        {
            return _userService.AddUser(user);
        }
        private User GetUserByUserName(string userName)
        {
            return _userService.GetUserByUserName(userName);
        }
    }
}

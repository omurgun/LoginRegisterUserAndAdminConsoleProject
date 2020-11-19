using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class UserClass
    {
        public void UserMenu()
        {
            Console.WriteLine("\t\t\tWelcome User Panel");
            Console.WriteLine("1- Add User");
            Console.WriteLine("2- Update User");
            Console.WriteLine("3- Delete User");
            Console.WriteLine("4- Get User");
            Console.WriteLine("5- GetAll User");
            Console.WriteLine("0- Exit");

            Console.Write("please choose (0-5): ");
            var choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    Console.Clear();
                    
                    break;
                case 2:
                    Console.Clear();
                   
                    break;
                case 3:
                    Console.Clear();
                   
                    break;
                case 4:
                    Console.Clear();
                   
                    break;
                case 5:
                    Console.Clear();
                   
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
}

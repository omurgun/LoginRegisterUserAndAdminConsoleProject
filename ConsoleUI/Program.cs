using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers.Ninject;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace ConsoleUI
{
    public class Program
    {

        public static void Main(string[] args)
        {
            while (true)
            {
                Menu();
            }
        }

        private static void Menu()
        {
            Console.WriteLine("\t\t\tWelcome");
            Console.WriteLine("1- Admin Panel");
            Console.WriteLine("2- User Panel");
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
                    AdminClass adminPanel = new AdminClass();
                    adminPanel.AdminMenu();
                    break;
                case 2:
                    Console.Clear();
                    UserClass userPanel = new UserClass();
                    userPanel.UserMenu();
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

        }

        
    }
}
using Pharm.Enums;
using Pharm.IRepositories;
using Pharm.Models;
using Pharm.Repositories;
using System;
using System.IO;

namespace Pharm
{
    public class Program
    {
        public static void Main(string[] args) 
        {

            #region MockData
            //User user = new User()
            //{
            //    FirstName = "Muhammadkarim",
            //    LastName = "Tukhtaboev",
            //    Login = "Admin123",
            //    Password = "123",
            //    Role = UserRole.User
            //};

            #endregion

            IUserRepository userRepo = new UserRepository();
            //var result = userRepo.Create(user);
            //Console.WriteLine(result.Id + " asosida saqlandi");
            Console.Write("login: ");
            string login = Console.ReadLine();
            Console.Write("password: ");
            string password = Console.ReadLine();

            User result = userRepo.Login(login, password);
            if(result == null) 
            {
                Console.WriteLine("Bunday foydalanuvchi mavjud emas");
            }
            else 
            {
                Console.WriteLine("\n");
                Console.WriteLine(result.ToString());
            }
        }

    }
}
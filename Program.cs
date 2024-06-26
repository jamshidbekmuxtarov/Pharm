using Microsoft.VisualBasic;
using Newtonsoft.Json;
using Pharm.Enums;
using Pharm.IRepositories;
using Pharm.Models;
using Pharm.Repositories;
using Pharm.Service;
using System;
using System.IO;
using System.Reflection.Metadata;

namespace Pharm
{
    public class Program
    {
        public static void Main(string[] args) 
        {

            #region MockData
            //User hondamir = new User()
            //{
            //    FirstName = "Hondamir",
            //    LastName = "Abduhoshimov",
            //    Login = "admin1456",
            //    Password = "0908"
            //};
            #endregion
            #region Sereliza and Diserelize
            //string json = JsonConvert.SerializeObject(hondamir);

            //string json = File.ReadAllText(Service.Constants.UserJsonPath);
            //User ali = JsonConvert.DeserializeObject<User>(json);

            //Console.WriteLine(ali.Login + "\n" + ali.Password); 
            #endregion
            #region Create User
            ////IUserRepository userRepo = new UserRepository();
            ////var result = userRepo.Create(newUser);
            ////Console.WriteLine(result.Id + " asosida saqlandi");

            #endregion
            #region Login Func()
            //Console.Write("login: ");
            //string login = Console.ReadLine();
            //Console.Write("password: ");
            //string password = Console.ReadLine();


            //User result = userRepo.Login(login, password);
            //if (result == null)
            //{
            //    Console.WriteLine("Bunday foydalanuvchi mavjud emas");
            //}
            //else
            //{
            //    Console.WriteLine("\n");
            //    Console.WriteLine(result.ToString());
            //}
            #endregion

            string json = File.ReadAllText(Service.Constants.UserJsonPath);
            List<University> universities = JsonConvert.DeserializeObject<List<University>>(json);

            //List<string> names = universities.Select(x => x.Name).ToList();
            //names.ForEach(x => Console.WriteLine(x));

            universities.Add(new University
            { 
                Name = "Dotnet Academy",
                country = "Uzbekistan",
                domains = new List<string>{ "dotnet.uz", "nimagap.uz"},
                
            });

            string result = JsonConvert.SerializeObject(universities);
            File.WriteAllText(Service.Constants.UserJsonPath, result);
            Console.WriteLine("done");

        }

    }
}
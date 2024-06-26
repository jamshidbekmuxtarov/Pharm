using Pharm.Service;
using Pharm.IRepositories;
using Pharm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pharm.Enums;
using Newtonsoft.Json;

namespace Pharm.Repositories
{
    public class UserRepository : IUserRepository
    {
        public User Create(User user)
        { 
            string json = File.ReadAllText(Service.Constants.UserJsonPath);
            List<User> users = JsonConvert.DeserializeObject<List<User>>(json);
            users.Add(user);

            string result = JsonConvert.SerializeObject(users);
            File.WriteAllText(Service.Constants.UserJsonPath, result); 
            return user;
        }

        public User Login(string login, string password)
        {
            string[] files = Directory.GetFiles(Constants.UserDbPath);
            foreach (string file in files) 
            {
                string[] userDetails = File.ReadAllLines(file);
                string userLogin = userDetails[4];
                string userPassword = userDetails[5];

                if(userLogin == login && userPassword == password)
                {
                    return new User()
                    {
                        Id = Guid.Parse(userDetails[0]),
                        FirstName = userDetails[1],
                        LastName = userDetails[2],
                        Role =(UserRole)Enum.Parse(typeof(UserRole),userDetails[3]),
                        Login = userDetails[4],
                        Password = userDetails[5]
                    };
                }
            }
            return null;
        }
        public void Print()
        {
            Console.WriteLine("Print qilindi");
        }
    }
}

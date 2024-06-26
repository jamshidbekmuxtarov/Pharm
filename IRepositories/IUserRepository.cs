using Pharm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharm.IRepositories
{
    public interface IUserRepository
    {
        User Create (User user);
        User Login (string username, string password);
        public void Print();
    }
}

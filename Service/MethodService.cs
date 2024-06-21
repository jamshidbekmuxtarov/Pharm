using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharm.Service
{
    public class MethodService
    {
        public static string GetUserPath(Guid Id)
        {
            return Path.Combine(Constants.UserDbPath, Id.ToString() + ".txt");
        }
    }
}

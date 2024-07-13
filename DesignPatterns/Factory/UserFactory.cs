using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public class UserFactory
    {
        public IUser GetUser(string userType)
        {
            if (string.Equals(userType, "doctor", StringComparison.OrdinalIgnoreCase))
            {
                return new Doctor();
            }
            else if (string.Equals(userType, "nurse", StringComparison.OrdinalIgnoreCase))
            {
                return new Nurse();
            }
            else
            {
                return null;
            }
        }
    }
}

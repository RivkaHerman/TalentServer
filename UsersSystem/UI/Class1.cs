using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JB
{
    class Class1
    {
        private UserLogic userLogic = new UserLogic();
        public void GetUsers()
        {
            List<UserDTO> users = userLogic.GetUsers(2);
            foreach (var item in users)
            {
                Console.WriteLine(item.birthdateUser);
            }
        }
    }
}

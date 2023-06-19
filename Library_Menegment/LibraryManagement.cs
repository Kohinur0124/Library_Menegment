using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Menegment
{
    public class LibraryManagement : LibraryManagementCore
    {
        public void RegisterUser(string firstname, string lastname)
        {

        }
        public void RegisterUser(string firstname, string lastname,string username)
        {
            var founduser = false;
            foreach (var user in Store.Users)
            {
                if (user.UserName == username)
                {
                    founduser = true;
                    break;

                }

            }
            if (founduser)
            {
                return;
            }
            Store.Users.Add(new User(firstname, lastname, username));
            
        }

        


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1_WinFOrms
{
    class User
    {
        bool isAdmin = false;
        private string login;
        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public void checkRole()
        {
            if(login == "admin" && password == "admin")
            {
                isAdmin = true;
            }
        }

        public bool getIsAdmin()
        {
            return isAdmin;
        }
    }
}

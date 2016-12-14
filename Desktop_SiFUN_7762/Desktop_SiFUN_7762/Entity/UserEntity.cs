using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop_SiFUN_7762.Entity
{
    class UserEntity
    {
        int id_role;

        public int Id_role
        {
            get { return id_role; }
            set { id_role = value; }
        }
        string username, password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public UserEntity(int id, string user, string pass) {
            Id_role = id;
            Username = user;
            Password = pass;

        }
    }
}

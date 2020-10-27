using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class UserModel
    {
        public void AltaUsuario(string loginName, string password, string firstname, string lastname, int age, string role)
        {
            User oUser = new User();
            oUser.loginName = loginName;
            oUser.firstName = firstname;
            oUser.lastName = lastname;
            oUser.password = password;
            oUser.age = age;
            oUser.role = role;
            UserController userController = new UserController();
            userController.InsertUser(oUser);
        }
    }
}

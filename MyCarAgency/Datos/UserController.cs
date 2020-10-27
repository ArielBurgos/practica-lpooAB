using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class UserController
    {
        public void InsertUser(User oUser)
        {
            using (db_agencyEntities db = new db_agencyEntities())
            {
                db.Users.Add(oUser);
                db.SaveChanges();
            }
        }
    }
}

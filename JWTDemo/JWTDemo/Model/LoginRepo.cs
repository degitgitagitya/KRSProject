using JWTDemo.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using Dapper;

namespace JWTDemo.Model
{
    public class LoginRepo
    {
        Database db;

        public LoginRepo()
        {
            db = new Database();
        }

        public bool delete(Login login)
        {
            db.Open();
            var data = db.conn.Delete<Login>(login);
            db.Close();
            return true;
        }

        public List<Login> getAll()
        {
            db.Open();
            var listLogin = db.conn.GetAll<Login>().ToList();
            db.Close();
            return listLogin;
        }

        public bool insert(Login login)
        {
            db.Open();
            var data = db.conn.Insert<Login>(login);
            db.Close();
            return true;
        }

        public Login getById(int id)
        {
            db.Open();
            var data = db.conn.Get<Login>(id);
            db.Close();
            return data;
        }

        public bool update(Login login)
        {
            db.Open();
            var feedback = db.conn.Update(login);
            db.Close();
            return feedback;
        }
    }
}

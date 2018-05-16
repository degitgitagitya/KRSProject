using Dapper.Contrib.Extensions;
using JWTDemo.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTDemo.Model
{
    public class AdminRepo
    {
        Database db;

        public AdminRepo()
        {
            db = new Database();
        }

        public bool delete(Admin admin)
        {
            db.Open();
            var data = db.conn.Delete<Admin>(admin);
            db.Close();
            return data;
        }

        public List<Admin> getAll()
        {
            db.Open();
            var listAdmin = db.conn.GetAll<Admin>().ToList();
            db.Close();
            return listAdmin;
        }

        public long insert(Admin admin)
        {
            db.Open();
            var data = db.conn.Insert<Admin>(admin);
            db.Close();
            return data;
        }

        public Admin getById(int id)
        {
            db.Open();
            var data = db.conn.Get<Admin>(id);
            db.Close();
            return data;
        }

        public bool update(Admin admin)
        {
            db.Open();
            var feedback = db.conn.Update(admin);
            db.Close();
            return feedback;
        }
    }
}

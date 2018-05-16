using JWTDemo.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using Dapper;

namespace JWTDemo.Model
{
    public class KelasRepo
    {
        Database db;

        public KelasRepo()
        {
            db = new Database();
        }

        public bool delete(Kelas kelas)
        {
            db.Open();
            var data = db.conn.Delete<Kelas>(kelas);
            db.Close();
            return data;
        }

        public List<Kelas> getAll()
        {
            db.Open();
            var listDosen = db.conn.GetAll<Kelas>().ToList();
            db.Close();
            return listDosen;
        }

        public long insert(Kelas kelas)
        {
            db.Open();
            var data = db.conn.Insert<Kelas>(kelas);
            db.Close();
            return data;
        }

        public Kelas getById(int id)
        {
            db.Open();
            var data = db.conn.Get<Kelas>(id);
            db.Close();
            return data;
        }

        public bool update(Kelas kelas)
        {
            db.Open();
            var feedback = db.conn.Update(kelas);
            db.Close();
            return feedback;
        }
    }
}

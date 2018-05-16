using JWTDemo.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using Dapper;

namespace JWTDemo.Model
{
    public class MhsRepo
    {
        Database db;

        public MhsRepo()
        {
            db = new Database();
        }

        public bool delete(Mhs mhs)
        {
            db.Open();
            var data = db.conn.Delete<Mhs>(mhs);
            db.Close();
            return data;
        }

        public List<Mhs> getAll()
        {
            db.Open();
            var listDosen = db.conn.GetAll<Mhs>().ToList();
            db.Close();
            return listDosen;
        }

        public long insert(Mhs mhs)
        {
            db.Open();
            var data = db.conn.Insert<Mhs>(mhs);
            db.Close();
            return data;
        }

        public Mhs getById(int id)
        {
            db.Open();
            var data = db.conn.Get<Mhs>(id);
            db.Close();
            return data;
        }

        public bool update(Mhs mhs)
        {
            db.Open();
            var feedback = db.conn.Update(mhs);
            db.Close();
            return feedback;
        }
    }
}

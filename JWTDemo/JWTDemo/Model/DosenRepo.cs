using JWTDemo.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using Dapper;

namespace JWTDemo.Model
{
    public class DosenRepo
    {
        Database db;

        public DosenRepo()
        {
            db = new Database();
        }

        public bool delete(Dosen dosen)
        {
            db.Open();
            var data = db.conn.Delete<Dosen>(dosen);
            db.Close();
            return data;
        }

        public List<Dosen> getAll()
        {
            db.Open();
            var listDosen = db.conn.GetAll<Dosen>().ToList();
            db.Close();
            return listDosen;
        }

        public long insert(Dosen dosen)
        {
            db.Open();
            var data = db.conn.Insert<Dosen>(dosen);
            db.Close();
            return data;
        }

        public Dosen getById(int id)
        {
            db.Open();
            var data = db.conn.Get<Dosen>(id);
            db.Close();
            return data;
        }

        public bool update(Dosen dosen)
        {
            db.Open();
            var feedback = db.conn.Update(dosen);
            db.Close();
            return feedback;
        }
    }
}

using JWTDemo.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using Dapper;

namespace JWTDemo.Model
{
    public class KrsRepo
    {
        Database db;

        public KrsRepo()
        {
            db = new Database();
        }

        public bool delete(Krs krs)
        {
            db.Open();
            var data = db.conn.Delete<Krs>(krs);
            db.Close();
            return true;
        }

        public List<Krs> getAll()
        {
            db.Open();
            var listDosen = db.conn.GetAll<Krs>().ToList();
            db.Close();
            return listDosen;
        }

        public bool insert(Krs krs)
        {
            db.Open();
            var data = db.conn.Insert<Krs>(krs);
            db.Close();
            return true;
        }

        public Krs getById(int id)
        {
            db.Open();
            var data = db.conn.Get<Krs>(id);
            db.Close();
            return data;
        }

        public bool update(Krs krs)
        {
            db.Open();
            var feedback = db.conn.Update(krs);
            db.Close();
            return feedback;
        }
    }
}

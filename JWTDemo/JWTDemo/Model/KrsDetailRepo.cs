using JWTDemo.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using Dapper;

namespace JWTDemo.Model
{
    public class KrsDetailRepo
    {
        Database db;

        public KrsDetailRepo()
        {
            db = new Database();
        }

        public bool delete(KrsDetail krs)
        {
            db.Open();
            var data = db.conn.Delete<KrsDetail>(krs);
            db.Close();
            return data;
        }

        public List<KrsDetail> getAll()
        {
            db.Open();
            var listDosen = db.conn.GetAll<KrsDetail>().ToList();
            db.Close();
            return listDosen;
        }

        public long insert(KrsDetail krs)
        {
            db.Open();
            var data = db.conn.Insert<KrsDetail>(krs);
            db.Close();
            return data;
        }

        public KrsDetail getById(int id)
        {
            db.Open();
            var data = db.conn.Get<KrsDetail>(id);
            db.Close();
            return data;
        }

        public bool update(KrsDetail krs)
        {
            db.Open();
            var feedback = db.conn.Update(krs);
            db.Close();
            return feedback;
        }
    }
}

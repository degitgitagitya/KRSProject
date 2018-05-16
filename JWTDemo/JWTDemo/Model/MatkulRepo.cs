using JWTDemo.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using Dapper;

namespace JWTDemo.Model
{
    public class MatkulRepo
    {
        Database db;

        public MatkulRepo()
        {
            db = new Database();
        }

        public bool delete(Matkul matkul)
        {
            db.Open();
            var data = db.conn.Delete<Matkul>(matkul);
            db.Close();
            return data;
        }

        public List<Matkul> getAll()
        {
            db.Open();
            var listDosen = db.conn.GetAll<Matkul>().ToList();
            db.Close();
            return listDosen;
        }

        public long insert(Matkul matkul)
        {
            db.Open();
            var data = db.conn.Insert<Matkul>(matkul);
            db.Close();
            return data;
        }

        public Matkul getById(int id)
        {
            db.Open();
            var data = db.conn.Get<Matkul>(id);
            db.Close();
            return data;
        }

        public bool update(Matkul matkul)
        {
            db.Open();
            var feedback = db.conn.Update(matkul);
            db.Close();
            return feedback;
        }
    }
}

using JWTDemo.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using Dapper;

namespace JWTDemo.Model
{
    public class JadwalRepo
    {
        Database db;

        public JadwalRepo()
        {
            db = new Database();
        }

        public bool delete(Jadwal jadwal)
        {
            db.Open();
            var data = db.conn.Delete<Jadwal>(jadwal);
            db.Close();
            return data;
        }

        public List<Jadwal> getAll()
        {
            db.Open();
            var listDosen = db.conn.GetAll<Jadwal>().ToList();
            db.Close();
            return listDosen;
        }

        public long insert(Jadwal jadwal)
        {
            db.Open();
            var data = db.conn.Insert<Jadwal>(jadwal);
            db.Close();
            return data;
        }

        public Jadwal getById(int id)
        {
            db.Open();
            var data = db.conn.Get<Jadwal>(id);
            db.Close();
            return data;
        }

        public bool update(Jadwal jadwal)
        {
            db.Open();
            var feedback = db.conn.Update(jadwal);
            db.Close();
            return feedback;
        }
    }
}

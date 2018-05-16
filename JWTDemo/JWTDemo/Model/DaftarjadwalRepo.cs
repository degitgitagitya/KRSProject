using JWTDemo.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using Dapper;

namespace JWTDemo.Model
{
    public class DaftarjadwalRepo
    {
        Database db;

        public DaftarjadwalRepo()
        {
            db = new Database();
        }

        public List<Daftarjadwals> getAll()
        {
            db.Open();
            var listJadwals = db.conn.Query<Daftarjadwals>("select jadwals.id, hari, waktu, kode_kelas, nama_matkul, dosens.nama from jadwals, kelass, dosens, matkuls where jadwals.id_matkul = matkuls.id and jadwals.id_kelas = kelass.id and jadwals.id_dosen = dosens.id").ToList();
            db.Close();
            return listJadwals;
        }

        public Daftarjadwals getById(int id)
        {
            db.Open();
            var data = db.conn.Query<Daftarjadwals>("select jadwals.id, hari, waktu, kode_kelas, nama_matkul, dosens.nama from jadwals, kelass, dosens, matkuls where jadwals.id_matkul = matkuls.id and jadwals.id_kelas = kelass.id and jadwals.id_dosen = dosens.id and jadwals.id = " + id + " ;").ToList();
            db.Close();
            Daftarjadwals dafjadwal = null;
            foreach (var item in data)
            {
                dafjadwal = item;
            }
            return dafjadwal;
        }
    }
}

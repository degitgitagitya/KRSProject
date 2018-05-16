using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTDemo.Model
{
    public class Daftarjadwals
    {
        private int id;
        private string hari;
        private string waktu;
        private string kode_kelas;
        private string nama_matkul;
        private string nama;

        public int Id { get => id; set => id = value; }
        public string Hari { get => hari; set => hari = value; }
        public string Waktu { get => waktu; set => waktu = value; }
        public string Kode_kelas { get => kode_kelas; set => kode_kelas = value; }
        public string Nama_matkul { get => nama_matkul; set => nama_matkul = value; }
        public string Nama { get => nama; set => nama = value; }
    }
}

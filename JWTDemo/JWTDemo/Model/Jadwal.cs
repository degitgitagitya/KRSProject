using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTDemo.Model
{
    public class Jadwal
    {
        private int id;
        private string hari;
        private string waktu;
        private int id_kelas;
        private int id_matkul;
        private int id_dosen;

        public int Id { get => id; set => id = value; }
        public string Hari { get => hari; set => hari = value; }
        public string Waktu { get => waktu; set => waktu = value; }
        public int Id_kelas { get => id_kelas; set => id_kelas = value; }
        public int Id_matkul { get => id_matkul; set => id_matkul = value; }
        public int Id_dosen { get => id_dosen; set => id_dosen = value; }
    }
}

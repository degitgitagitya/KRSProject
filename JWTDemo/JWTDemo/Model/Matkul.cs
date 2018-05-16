using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTDemo.Model
{
    public class Matkul
    {
        private int id;
        private string kd_matkul;
        private string nama_matkul;
        private int sks;

        public int Id { get => id; set => id = value; }
        public string Kd_matkul { get => kd_matkul; set => kd_matkul = value; }
        public string Nama_matkul { get => nama_matkul; set => nama_matkul = value; }
        public int Sks { get => sks; set => sks = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTDemo.Model
{
    public class Kelas
    {
        private int id;
        private string kode_kelas;
        private string tempat;

        public int Id { get => id; set => id = value; }
        public string Kode_kelas { get => kode_kelas; set => kode_kelas = value; }
        public string Tempat { get => tempat; set => tempat = value; }
    }
}

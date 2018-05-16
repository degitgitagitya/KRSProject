using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTDemo.Model
{
    public class Krs
    {
        private int id;
        private string semestertahun;
        private int id_mhs;
        private string nim;
        private string nama;

        public int Id { get => id; set => id = value; }
        public string Semestertahun { get => semestertahun; set => semestertahun = value; }
        public int Id_mhs { get => id_mhs; set => id_mhs = value; }
        public string Nim { get => nim; set => nim = value; }
        public string Nama { get => nama; set => nama = value; }
    }
}

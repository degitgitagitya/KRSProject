using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTDemo.Model
{
    public class Dosen
    {
        private int id;
        private string nip;
        private string nama;
        private string kode_dosen;

        public int Id { get => id; set => id = value; }
        public string Nip { get => nip; set => nip = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Kode_dosen { get => kode_dosen; set => kode_dosen = value; }
    }
}

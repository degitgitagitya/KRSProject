using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTDemo.Model
{
    public class Mhs
    {
        private int id;
        private string nim;
        private string nama_mhs;
        private string jk;
        private string notelp;
        private string email;
        private string foto;

        public int Id { get => id; set => id = value; }
        public string Nim { get => nim; set => nim = value; }
        public string Nama_mhs { get => nama_mhs; set => nama_mhs = value; }
        public string Jk { get => jk; set => jk = value; }
        public string Notelp { get => notelp; set => notelp = value; }
        public string Email { get => email; set => email = value; }
        public string Foto { get => foto; set => foto = value; }
    }
}

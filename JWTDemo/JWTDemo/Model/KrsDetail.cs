using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTDemo.Model
{
    public class KrsDetail
    {
        private int id;
        private int id_krs;
        private int id_jadwal;

        public int Id { get => id; set => id = value; }
        public int Id_krs { get => id_krs; set => id_krs = value; }
        public int Id_jadwal { get => id_jadwal; set => id_jadwal = value; }
    }
}

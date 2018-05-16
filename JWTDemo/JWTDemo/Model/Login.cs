using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTDemo.Model
{
    public class Login
    {
        private int id;
        private string nim;
        private string password;

        public int Id { get => id; set => id = value; }
        public string Nim { get => nim; set => nim = value; }
        public string Password { get => password; set => password = value; }
    }
}

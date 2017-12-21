using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL_Tier
{
    class TaiKhoan
    {
        private string username;
        private string password;
        private int gID;

        public TaiKhoan()
        {

        }

        public TaiKhoan(string username, string password, int gID)
        {
            this.Username = username;
            this.Password = password;
            this.GID = gID;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int GID { get => gID; set => gID = value; }
    }
}

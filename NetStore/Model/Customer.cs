using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NetStore.Model
{
    public class Customer
    {
        private string username;
        private string password;
        private int id;
        public Customer(string username, string password, int id) { 
            this.username = username;
            this.password = password;
            this.id = id;
        }
        public string Username 
        { 
            set { username = value; }
            get { return username; } 
        }
        public string Password
        {
            set { password = value; }
            get { return password; }
        }
        public int Id
        {
            set { id = value; }
            get { return id; }
        }

    }
}

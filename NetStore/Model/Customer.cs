using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetStore.Model
{
    public class Customer
    {
        private int id;
        private string username;
        private string password;
        public Customer(string username, string password) { 
            this.username = username;
            this.password = password;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetStore.Model
{
    internal class Staff
    {
        private string nameStaff;
        private string username;
        private string password;

        public Staff(string nameStaff, string username, string password)
        {
            this.nameStaff = nameStaff;
            this.username = username;
            this.password = password;
        }
        public string NameStaff { 
            set { nameStaff = value; }
            get {  return nameStaff; } 
        }
        public string Username 
        { 
            set { username = value; }
            get { return username; } }
        public string Password
        {
            set { password = value; }
            get { return password; }
        }
    }
}

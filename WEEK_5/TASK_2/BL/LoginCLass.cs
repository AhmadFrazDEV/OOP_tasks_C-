using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_2.BL
{
    class LoginCLass
    {
        private string Name;
        private string Password;
        private string Role;
        
        public LoginCLass(string Name,string Password,string Role)
        {
            this.Name = Name;
            this.Password = Password;
            this.Role = Role;
        }
        public void setName(string Name)
        {
            this.Name = Name;
        }
        public void setPassword(string Password)
        {
            this.Password = Password;
        }
        public void setRole(string Role)
        {
            this.Role = Role;
        }
        public string getName()
        {
            return Name;
        }
        public string getPassword()
        {
            return Password;
        }
        public string getRole()
        {
            return Role;
        }
    }
}

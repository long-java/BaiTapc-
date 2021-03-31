using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Account
    {
        public enum Quyen
        { 
            Admin,
            Manager, 
            Employee,
            None
        }

        public Account()
        {

        }

        public Account(int id, string userName, string password, Quyen quyen, bool isActive)
        {
            Id = id;
            Username = userName;
            Password = password;
            this.qQuyen = quyen;
            this.isActive = isActive;
        }

        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public Quyen qQuyen { get; set; }

        public bool isActive { get; set; }

        public override string ToString()
        {
            return ("Id: " + Id + " |UserName: " + Username + "|Password: " + Password + " |Quyen: " + qQuyen + " |isActive: " + isActive);
        }

    }
}

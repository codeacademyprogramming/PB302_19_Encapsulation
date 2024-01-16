using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    internal class Account
    {
        public string Fullname;
        public string Email;
        public string Password;

        public virtual string GetInfo()
        {
            return $"Fullname: {Fullname} - Email: {Email}";
        }
    }
}

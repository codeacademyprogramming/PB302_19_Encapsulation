using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    internal class StudentAccount:Account
    {
        public string GroupNo;

        public override string GetInfo()
        {
            //return $"Fullname: {Fullname} - Email: {Email} - GroupNo: {GroupNo}";
            return $"{base.GetInfo()} - GroupNo: {GroupNo}";

        }
    }
}

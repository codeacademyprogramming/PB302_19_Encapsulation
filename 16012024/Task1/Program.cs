using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentAccount stdAcc = new StudentAccount
            {
                Email = "std@gmail.com",
                Fullname = "Hikmet Abbasov",
                GroupNo = "PB302",
                Password = "Hikmet@123"
            };

            Console.WriteLine(stdAcc.GetInfo());
        }
    }
}

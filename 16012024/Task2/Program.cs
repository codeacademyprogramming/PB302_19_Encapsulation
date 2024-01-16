using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human hmn1 = new Human();

            hmn1.Fullname = "Hikmet Abbasov";
            hmn1.SetAge(20);

            Console.WriteLine(hmn1.Fullname);
            Console.WriteLine(hmn1.GetAge());

            hmn1.BirthPlace = "Baku";
            hmn1.BirthPlace = "Shaki";
            hmn1.BirthPlace = null;

            Console.WriteLine(hmn1.BirthPlace);


        }
    }
}

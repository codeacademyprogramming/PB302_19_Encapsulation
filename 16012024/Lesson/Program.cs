using System;
using System.Net.WebSockets;

namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product pr1 = new Product(100);

            //Console.WriteLine(pr1.Name);
            //pr1.Name = null;

            pr1.SetName("Qulaqciq");
            pr1.SetName(null);

            Console.WriteLine(pr1.GetName());

            Product pr2 = new Product(10);
            pr2.SetName(pr1.GetName());


            //pr1.SetPrice(120);
            //pr1.SetPrice(50);
            //pr1.SetPrice(-10);
            pr1.Price = 120;


            pr1.Sell();
            pr1.Sell();
            pr1.Sell();
            pr1.Sell();
            pr1.Sell();

            //Console.WriteLine(pr1.GetPrice());
            Console.WriteLine(pr1.Price);
            Console.WriteLine(pr1.GetTotalProfit());
            Console.WriteLine(pr1.TotalProfit);





        }
    }
}

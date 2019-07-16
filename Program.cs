using System;

namespace flower_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            FlowerShop myShop = new FlowerShop();

            foreach (IColor flower in myShop.BirthdayArrangement)
            {
                // what goes here?
            }
        }
    }
}

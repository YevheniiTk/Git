namespace SalesManagement
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var ivan = new Customer("Ivan");
            var john = new Customer("John");
            var mike = new Customer("Mike");

            var onlineShop = new OnlineShop();

            onlineShop.EventNewGoods += ivan.GotNewGoods;
            onlineShop.EventNewGoods += john.GotNewGoods;
            onlineShop.EventNewGoods += mike.GotNewGoods;

            onlineShop.NewGoods("Black T-shirt");

            Console.WriteLine("The end!!!");
            Console.ReadLine();
        }
    }
}

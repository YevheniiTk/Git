namespace SalesManagement
{
    using System;

    public class Customer
    {
        private string _name;

        public Customer(string name)
        {
            Console.WriteLine($"Create new castomer {name}");
            this._name = name;
        }

        public void GotNewGoods(object obj, GoodsInfoEventArgs goodsInfoEventArgs)
        {
            Console.WriteLine($"Got information about new goods - " +
                              $"{(obj as OnlineShop).Goods} for {_name}");
        }
    }
}

namespace SalesManagement
{
    using System;

    public class OnlineShop
    {
        public OnlineShop()
        {
            Console.WriteLine($"Create OnlineShop");
        }

        public event EventHandler<GoodsInfoEventArgs> EventNewGoods;

        public string Goods { get; private set; }

        public void NewGoods(string goodsName)
        {
            this.Goods = goodsName;
            Console.WriteLine($"Add new goods in Online Shop {goodsName}");

            this.EventNewGoods?.Invoke(this, new GoodsInfoEventArgs(goodsName));
        }
    }
}

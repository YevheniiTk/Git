namespace SalesManagement
{
    using System;

    public class GoodsInfoEventArgs : EventArgs
    {
        public GoodsInfoEventArgs(string goodsName)
        {
            Console.WriteLine($"Create GoodsInfoEventArgs {goodsName}");
            this.GoodsName = goodsName;
        }

        public string GoodsName { get; private set; }
    }
}

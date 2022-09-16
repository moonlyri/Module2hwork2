using System;
namespace Shop
{

    public class Order
    {
        public Order()
        {
            var Basket1 = new Order.Random().Next(1, 100);

        }

        private int Order1()
        {
            throw new NotImplementedException();
        }

        private class Random
        {
            internal object Next(int v1, int v2)
            {
                throw new NotImplementedException();
            }
        }
        private readonly string order = "Your order:" + Basket1 + "is succesful";
    }

}


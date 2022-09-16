namespace Shop
{
    internal class Basket1 : Items
    {
        
        public Basket1()
        {
            int[] basket = new int[10];
            for (int i = 0; i <= basket.Length; i++)
            {
                int newbasket = new Random().Next(1, 1000);
            }
        }
        Basket1 basket = new Order();
        public static implicit operator Basket1(Order v)
        {
            throw new NotImplementedException();
        }
    }
}
namespace laba4
{
    abstract class Product
    {
        protected int _amount;
        protected int _price;

        public Product(int amount, int price)
        {
            _amount = amount;
            _price = price;
        }

        public int Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public override string ToString()
        {
            Console.WriteLine("----Информация о товаре----");
            Console.WriteLine($"Количество: {_amount}");
            Console.WriteLine($"Цена: {_price} руб.");
            return "\0";
        }
    }


}

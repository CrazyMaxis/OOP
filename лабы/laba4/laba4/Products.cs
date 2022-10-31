namespace laba4
{
    interface IProduct
    {
        void ShowInfo();
        string ToString();
    }

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

        public virtual void ShowInfo()
        {
            Console.WriteLine("----Информация о товаре----");
            Console.WriteLine($"Количество: {_amount}");
            Console.WriteLine($"Цена: {_price} руб.");
        }

        public override string ToString()
        {
            Console.WriteLine(GetType().Name);
            return "\0";
        }
    }

    abstract class Pastry : Product, IProduct
    {
        protected int _weight;
        protected string _factory;

        public Pastry(int amount, int price, int weight, string factory) : base(amount, price)
        {
            _weight = weight;
            _factory = factory;
        }

        public int Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        public string Factory
        {
            get { return _factory; }
            set { _factory = value; }
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Вес: {_weight}");
            Console.WriteLine($"Произведено на заводе: {_factory}");
        }

        void IProduct.ShowInfo()
        {
            Console.WriteLine("Вызов метода из интерфейса.");
        }
    }

    abstract class Commodity : Product, IProduct
    {
        protected string _name;

        public Commodity(int amount, int price, string name) : base(amount, price)
        {
            _name = name;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Название: {_name}");
            base.ShowInfo();
        }
    }
}

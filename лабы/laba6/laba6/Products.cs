namespace laba6
{
    interface IProduct
    {
        void ShowInfo();
        string ToString();
    }

    abstract class Product : IProduct
    {
        protected int _price;

        public Product(int price)
        {
            _price = price;
        }

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }

        enum Availability
        {
            notavail,
            avail
        }

        struct CheckAvail
        {
            static Availability _avail = Availability.avail;
            public static string Check()
            {
                if (_avail == Availability.avail)
                {
                    return "Есть в наличии";
                }

                else
                {
                    return "Нет в наличии";
                }
            }
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine("----Информация о товаре----");
            Console.WriteLine($"Состояние: {CheckAvail.Check()}");
            Console.WriteLine($"Цена за 1 шт / 1 кг: {_price} руб.");
        }

        public override string ToString()
        {
            return GetType().Name;
        }
    }

    abstract class Pastry : Product, IProduct
    {
        protected int _weight;
        protected string _factory;

        public Pastry(int price, int weight, string factory) : base(price)
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
            Console.WriteLine($"Вес: {_weight} грамм.");
            Console.WriteLine($"Произведено на заводе: {_factory}.");
        }

        void IProduct.ShowInfo()
        {
            Console.WriteLine("Вызов метода из интерфейса.");
        }
    }

    abstract class Commodity : Product, IProduct
    {
        protected int _amount;
        protected string _name;

        public Commodity(int amount, int price, string name) : base(price)
        {
            _amount = amount;
            _name = name;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Название: {_name}.");
            Console.WriteLine($"Количество: {_amount}.");
        }
    }

    internal class Cake : Pastry, IProduct
    {
        public string _name;
        private int _pieces;

        public Cake(int price, int weight, string factory, string name) : base(price, weight, factory)
        {
            _name = name;
            _pieces = weight / 100;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Название торта: {_name}.");
            Console.WriteLine($"{_pieces} кусков доступно для продажи.");
        }

        public void Buy()
        {
            if (_pieces != 0)
            {
                Console.WriteLine("Вы купили кусочек торта.");
                _pieces--;
            }
            else
            {
                Console.WriteLine("Недостаточно торта для продажи.");
            }
        }
    }

    internal class Candy : Pastry, IProduct
    {
        public string _name;

        public Candy(int price, int weight, string factory, string name) : base(price, weight, factory)
        {
            _name = name;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Навзвание конфет: {_name}.");
        }

        public void Buy(int weight)
        {
            if (_weight >= weight)
            {
                Console.WriteLine($"Вы купили {_weight} грамм конфет.");
                _weight -= weight;
            }
            else
            {
                Console.WriteLine($"Недостаточно грамм конфет для продажи. Осталось всего {_weight} грамм конфет.");
            }
        }
    }

    sealed class Watch : Commodity, IProduct
    {
        public Watch(int amount, int price, string name) : base(amount, price, name) { }

        public void Buy()
        {
            if (_amount != 0)
            {
                Console.WriteLine("Вы купили часы.");
                _amount--;
            }
            else
            {
                Console.WriteLine("Недостаточно часов для продажи.");
            }
        }
    }

    partial class Flower : Commodity, IProduct
    {
        public Flower(int amount, int price, string name) : base(amount, price, name) { }

        public override bool Equals(object obj)
        {

            if (obj is Flower) { return true; }
            return false;
        }

        public override int GetHashCode()
        {
            int hash = 0;
            Random random = new Random();
            for (int i = 0; i < _name.Length; i++)
            {
                hash += _name[i];
            }
            hash *= random.Next();
            return Math.Abs(hash);
        }
    }

    static class Printer
    {
        public static void IAmPrinting(Product obj)
        {
            Console.WriteLine(obj.ToString());
        }
    }
}

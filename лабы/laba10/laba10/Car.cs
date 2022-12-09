namespace laba10
{
    internal class Car
    {
        const int a = 0;
        static private int? _counter;
        private readonly int _id;
        private string? _brand;
        private string? _color;
        private int? _price;
        private int? _realeseYear;
        private int? _registrationNumber;

        public Car()
        {
            _counter++;
        }

        public Car(string? color, string? brand, int? realeseYear) : this(brand)
        {
            _counter++;
            _id = GetHashCode();
            _realeseYear = realeseYear;
        }

        private Car(string? brand)
        {
            _brand = brand;
        }

        public Car(string? brand = null, int? realeseYear = null, string? color = null, int? price = null, int? registrationNumber = null)
        {
            _brand = brand;
            _id = GetHashCode();
            RealeseYear = (int)realeseYear;
            _color = color;
            _price = price;
            _registrationNumber = registrationNumber;
        }

        public int Counter
        {
            get { return (int)_counter; }
        }

        public int ID
        {
            get { return (int)_id; }
        }

        public string Brand
        {
            get { return (string)_brand; }
            set { _brand = value; }
        }
        public override int GetHashCode()
        {
            int hash = 0;
            Random rand = new Random();
            for (int i = 0; i < _brand.Length; i++)
            {
                hash += _brand[i];
            }
            hash *= rand.Next(1000, 999999);
            return (int)Math.Abs(hash * _brand.Length);
        }
        public int RealeseYear
        {
            get { return (int)_realeseYear; }
            set{ _realeseYear = value; }
        }

        public string Color
        {
            get { return (string)_color; }
            set { _color = value; }
        }

        public int Price
        {
            get { return (int)_price; }
            set { _price = value; }
        }

        public int RegistrationNumber
        {
            get { return (int)_registrationNumber; }
            set { _registrationNumber = value; }
        }

        public void GetId(out int id)
        {
            id = (int)_id;
        } // out

        public void GetGroup(ref int price)
        {
            price = (int)_price;
        } // ref

        public void GetInformationOfCar()
        {
            Console.WriteLine("Информация о машине.");
            Console.WriteLine($"ID машины: {_id}");
            Console.WriteLine($"Марка машины: {_brand}");
            Console.WriteLine($"Цвет машины: {_color}");
            Console.WriteLine($"Год выпуска: {_realeseYear}");
            Console.WriteLine($"Регистрационный номер: {_registrationNumber}");
            Console.WriteLine($"Цена: {_price}$");
            Console.WriteLine(new String('-', 50));
        }
    }
}

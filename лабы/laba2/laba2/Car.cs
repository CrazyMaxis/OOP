using System.Collections.Specialized;
using System.Diagnostics.Metrics;
using System.Net;
using System.Text.RegularExpressions;

namespace laba2
{
    public class Car
    {
        const int a = 0;
        static private int? _counter;
        private readonly int _id;
        private string? _brand;
        private string? _color;
        private int? _price;
        private int? _realeseYear;
        private int? _registrationNumber;

        static Car()
        {
            Console.WriteLine("В данной программе хранится информация об студентах!");
        } // static конструктор

        public Car()
        {
            _counter++;
        }

        //public Car(int id, string? brand) : this(brand)
        //{
        //    _counter++;
        //}

        //private Car(string? brand)
        //{
        //    _brand = brand;
        //}

        //public Car(int id = 0, string? brand = null, DateTime? realeseYear = null, string? color = null, int? price = null, int? registrationNumber = null)
        //{
        //    _id = id;
        //    _brand = brand;
        //    _realeseYear = realeseYear;
        //    _color = color;
        //    _price = price;
        //    _registrationNumber = registrationNumber;
        //}


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

        public int RealeseYear
        {
            get { return (int)_realeseYear; }
            set {
                while (!ValidationOfInformation.CheckRealeaseYear(value))
                {
                    Console.WriteLine("Неправильно введены данные. Попробуйте еще раз.");
                    value = Convert.ToInt32(Console.ReadLine());
                }
                _realeseYear = value; 
                }
        }

        public string Color
        {
            get { return (string)_color; }
            set { _color = value; }
        }

        public int Price
        {
            get { return (int)_price; }
            set {
                while (!ValidationOfInformation.CheckPrice(value))
                {
                    Console.WriteLine("Неправильно введены данные. Попробуйте еще раз.");
                    value = Convert.ToInt32(Console.ReadLine());
                }
                _price = value; 
                }
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
        }
    }

    partial class ValidationOfInformation
    {
        public static bool CheckPrice(int price)
        {
            if (price < 1000)
                return false;
            return true;
        }
    }
}

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
        private DateTime? _realeseYear = new DateTime();
        private string? _color;
        private int? _price;
        private int? _registrationNumber;

        static Car()
        {
            Console.WriteLine("В данной программе хранится информация об студентах!");
        } // static конструктор

        public Car(int id, string? brand) : this(brand) 
        {
            _counter++;
        }
        
        private Car(string? brand)
        {
            _brand = brand;
        }

        public Car(int id = 0, string? brand = null, DateTime? realeseYear = null, string? color = null, int? price = null, int? registrationNumber = null)
        {
            _id = id;
            _brand = brand;
            _realeseYear = realeseYear;
            _color = color;
            _price = price;
            _registrationNumber = registrationNumber;
        }
    }
}

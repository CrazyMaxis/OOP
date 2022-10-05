using System.Diagnostics.Metrics;
using System.Net;
using System.Text.RegularExpressions;

namespace laba2
{
    public class Car
    {
        static private int? _counter;
        private int? _id;
        private string? _brand;
        private DateTime _realeseYear = new DateTime();
        private string? _color;
        private int? _price;
        private int? _registrationNumber;

        static Car()
        {
            Console.WriteLine("В данной программе хранится информация об студентах!");
        } // static конструктор
    }
}

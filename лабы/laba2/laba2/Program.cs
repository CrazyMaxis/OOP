using System.Diagnostics.Metrics;

namespace laba2
{
    class Override
    {
        private readonly string _brand;
        public Override(string brand)
        {
            _brand = brand;
        }
        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }
        public override string ToString()
        {
            return _brand;
        }
    }

    partial class ValidationOfInformation
    {
        public static bool CheckRealeaseYear(int realeaseYear){
            if (realeaseYear < 1885 || realeaseYear > 2022)
                return false;
            return true;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Car Car1 = new Car ("black", "Mercedes", 2021);
            var Car2 = new { color = "purple", brand = "Lamborgini", price = 33333333 };
            Car BMW = new Car("BMW", 2019, "yellow", 37000, 7777);
            Car Tesla = new Car("Tesla", 2012, "white", 40000, 1111);
            Car Mercedes = new Car("Mercedes", 1996, "gray", 3000, 3125);
            Car[] AutoPark = {BMW, Tesla, Mercedes, Car1};

            Console.WriteLine("1 task");
            for (int i = 0; i < 4; i++)
            {
                if (AutoPark[i].Brand == "Mercedes")
                    AutoPark[i].GetInformationOfCar();
            }

            Console.WriteLine();
            Console.WriteLine("2 task");
            int n = 7;
            for (int i = 0; i < 4; i++)
            {
                if (AutoPark[i].Brand == "Mercedes" && 2022 - AutoPark[i].RealeseYear > 7)
                    AutoPark[i].GetInformationOfCar();
            }
        }
    }
}
namespace laba10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] months = {
                "January",
                "February",
                "March",
                "April",
                "May",
                "June",
                "July",
                "August",
                "September",
                "October",
                "November",
                "December"
            };

            Console.WriteLine("Введите длину месяца: ");
            int n = Convert.ToInt32(Console.ReadLine());

            IEnumerable<string> lengthN = from month in months where month.Length == n select month;

            var WinterSummer = months.Where((month, i) => i < 2 || i > 4 && i < 8 || i == 11);
            var alphabetOrder = months.OrderBy(month => month);
            var withU = months.Where(month => month.Contains("u") && month.Length > 3);

            foreach (string s in lengthN)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();

            foreach (string s in WinterSummer)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();

            foreach (string s in alphabetOrder)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();

            foreach (string s in withU)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();

            string brand = "AAA";
            int years = 15;
            string color = "white";

            List<Car> list = new List<Car>()
            {
                new Car("AAA", 2010, "black", 20000, 123456789),
                new Car("BBB", 2000, "black", 19000, 123456789),
                new Car("CCC", 2000, "white", 18000, 123456789),
                new Car("DDD", 1990, "yellow", 17000, 123456789),
                new Car("AAA", 2007, "white", 19000, 123456789),
                new Car("BBB", 1999, "blue", 5000, 123456789),
                new Car("XXX", 2022, "white", 100, 123456789),
                new Car("YYY", 1950, "black", 190000, 123456789),
                new Car("ZZZ", 2000, "black", 19000, 123456789),
                new Car("AAA", 2021, "white", 19000, 123456789),
            };

            var task1 = from car in list where car.Brand == brand select car;
            var task2 = list.Where(car => car.Brand == brand && 2022 - car.RealeseYear >= 15);
            var task3 = list.Where(car => car.Color == color && car.Price <= 20000);
            var task4 = list.Min(car => car.RealeseYear);
            var task5 = list.OrderByDescending(car => car.RealeseYear).Take(5);
            var task6 = list.OrderByDescending(car => car.Price);
            var task7 = list.Union(task3).OrderBy(car => car.RealeseYear).Where(car => car.Color == "white").Skip(1).Max();
            var task8 = list.Join(task2, car1 => car1.Brand, car2 => car2.Brand, (car1, car2) => new {price = car1.Price, color = car2.Color});

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
using System.Net;

namespace laba4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product obj1 = new Candy(5, 500, "Комунарка", "Шоколапки");
            Pastry obj2 = new Cake(15, 2000, "Тортики от Светика", "Медовик");
            
            Cake cake = obj2 as Cake;

            if (obj1 is Candy candy)
            {
                candy.ShowInfo();
                candy.Buy(364);
            }

            Flower flower = new Flower(15, 3, "Роза");
            Watch watch = new Watch(3, 500, "Томми Хуй Фига");

            Product[] products = { cake, flower, watch };
            Console.WriteLine();
            Console.WriteLine("Вызов метода IAmPrinting");
            foreach (var item in products)
            {
                Printer.IAmPrinting(item);
            }
        }
    }
}
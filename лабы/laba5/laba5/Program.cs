namespace laba5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Candy obj1 = new Candy(5, 500, "Комунарка", "Шоколапки");
            Cake obj2 = new Cake(15, 2000, "Тортики от Светика", "Медовик");

            Pastry cake = obj2 as Pastry;


            if (obj1 is Product candy)
            {
                candy.ShowInfo();
                ((IProduct)candy).ShowInfo();
            }

            Flower flower = new Flower(15, 3, "Роза");
            Watch watch = new Watch(3, 500, "Томми Х Фига");

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
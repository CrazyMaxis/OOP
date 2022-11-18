namespace laba5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Candy candy1 = new Candy(7, 543, "Maximus", "Victorius");
            Cake cake = new Cake(15, 2000, "Комунарка", "Медовик");
            Candy candy2 = new Candy(10, 321, "Maximus", "Genesis");


            Pastry[] products = { candy1, cake, candy2};

            Gift gift = new Gift();

            foreach (var i in products)
            {
                gift.addPastry(i);
            }
            gift.Show();
            gift.removePastry(2);
            gift.Show();

            Console.WriteLine($"Общая цена подарка: {Controller.GiftPrice(gift)}");
            Console.WriteLine(); Console.WriteLine("Отсортированный по весу список:"); Console.WriteLine();
            Gift giftSorted = Controller.WeightSort(gift);
            giftSorted.Show();
            Console.WriteLine("Компонент с наименьшим весом: " + Controller.FindMinWeight(gift));

            Console.WriteLine("\n\n- - - - - - - - Тест чтения файла - - - - - - - -");
            Gift container = new Gift();
            Controller.ReadFile(container, @"C:\Users\USER\Desktop\лабы\3сем\ооп\laba5\laba5\Gift.txt");
            container.Show();
        }
    }
}
namespace laba3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List list1 = new List();
            List list2 = new List();
            List list3 = new List();

            list1.AddNode("A");
            list1.AddNode("B");
            list2.AddNode("C");
            list2.AddNode("D");

            list1.ShowInfo();
            list2.ShowInfo();

            if (list3)
                Console.WriteLine("Пустой");
            else
                Console.WriteLine("Не пустой");

            list3 = list1 + list2;
            list3.ShowInfo();

            if (list3)
                Console.WriteLine("Пустой");
            else
                Console.WriteLine("Не пустой");

            List.Production Product1 = new List.Production(123, "ИП ПИгМар");
            List.Developer Developer1 = new List.Developer(1, "Поздняков Максим Игоревич", "BelBet");
        }
    }
}
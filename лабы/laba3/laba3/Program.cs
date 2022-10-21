namespace laba3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List list1 = new List();
            List list2 = new List();
            List list3 = new List();
            List listl = new List();

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

            listl.AddNode("AB1X2");
            List.Production Product1 = new List.Production(123, "ИП ПИгМар");
            List.Developer Developer1 = new List.Developer(1, "Поздняков Максим Игоревич", "BelBet");

            list1.AddNode("1");
            list1.AddNode("X");
            list1.AddNode("2");
            list1.AddNode("ZXC");
            Console.WriteLine(StaticOperations.Count(list1));
            Console.WriteLine(StaticOperations.getSumString(list1));
            Console.WriteLine(StaticOperations.LongestInfo(list1));

            Console.WriteLine(list1.GetLastNumber());
            list1.DeleteAnyElement("ZXC");
            listl.ShowInfo();
        }
    }
}
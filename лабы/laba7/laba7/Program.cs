namespace laba7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<string> list = new List<string>();

                Console.WriteLine(" - - - - - Вывод списка string - - - - - ");
                list.AddNode("Pozdnyakov");
                list.AddNode("Maxim");
                list.AddNode("Igorevich");
                list.ShowInfo();

                list.DeleteNode("Igorevich");
                //list.DeleteNode("Maxim");    // ошибка (не найден элемент)

                Console.WriteLine(" - - - - - Вывод списка без удалённого элемента - - - - - ");
                list.ShowInfo();

                List<int> intlist = new List<int>();
                Console.WriteLine(" - - - - - Вывод списка инт - - - - - ");
                intlist.AddNode(1);
                intlist.AddNode(2);
                intlist.AddNode(3);
                intlist.ShowInfo();

                List<double> doublelist = new List<double>();
                Console.WriteLine(" - - - - - Вывод списка дабл - - - - - ");
                doublelist.AddNode(1.1);
                doublelist.AddNode(2.2);
                doublelist.AddNode(3.3);
                doublelist.ShowInfo();

                Cake cake1 = new Cake(11, 123, "aaa", "AAA");
                Cake cake2 = new Cake(22, 321, "bbb", "BBB");
                Cake cake3 = new Cake(33, 111, "ccc", "CCC");
                List<Cake> cakelist = new List<Cake>();
                Console.WriteLine(" - - - - - Вывод списка cake - - - - - ");
                cakelist.AddNode(cake1);
                cakelist.AddNode(cake2);
                cakelist.AddNode(cake3);
                cakelist.ShowInfo();

                StaticOperations.InFile(cakelist, "C:\\Users\\USER\\Desktop\\лабы\\3сем\\ооп\\laba7\\laba7\\output.txt");
                List<Cake> cakelist2 = new List<Cake>();
                StaticOperations.ReadFile(cakelist2, "C:\\Users\\USER\\Desktop\\лабы\\3сем\\ооп\\laba7\\laba7\\output.txt");
                Console.WriteLine(" - - - - - Вывод считанных данных - - - - - ");
                cakelist2.ShowInfo();
            }
            catch (DeleteNotFounded exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                Console.WriteLine("Тест закончился");
            }
        }
    }
}
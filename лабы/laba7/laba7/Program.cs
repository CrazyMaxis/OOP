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
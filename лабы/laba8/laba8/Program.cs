namespace laba8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Programmer.Action Language;
            Programmer programmer = new Programmer();
            List<string> LP = new List<string> { "Ruby", "C#", "Kotlin", "Pascal", "Python", "GoLang", "VisualBasic", "Dart", "JS", "Java" };

            Console.Write("Список: ");
            foreach (string item in LP)
            {
                Console.Write(item + "   ");
            }
            Console.WriteLine();

            programmer.delete += list =>
            {
                Console.Write("Измененный: ");
                foreach (string item in LP)
                {
                    Console.Write(item + "   ");
                }
                Console.WriteLine();
            };

            programmer.mutate += list =>
            {
                Console.Write("Перестановка: ");
                foreach (string item in LP)
                {
                    Console.Write(item + "   ");
                }
                Console.WriteLine();
            };

            Language = programmer.Delete;
            Language += programmer.Mutate;
            Language += programmer.Mutate;
            Language += programmer.Mutate;
            Language(LP);
        }
    }
}
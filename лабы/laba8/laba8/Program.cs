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

            Func<string, string> A;
            string str = "Maxim; Pozdnyakov. made, this; str";
            Console.WriteLine($"\n\nСтрока: {str}");
            A = StringEditor.RemovePunctuation;
            Console.WriteLine($"{A.Method.Name}: {A(str)}");
            str = A(str);
            A += StringEditor.AddSymbol;
            Console.WriteLine($"{A.Method.Name}: {A(str)}");
            str = A(str);
            A += StringEditor.ToUpper;
            Console.WriteLine($"{A.Method.Name}: {A(str)}");
            str = A(str);
            A += StringEditor.ToLower;
            Console.WriteLine($"{A.Method.Name}: {A(str)}");
            str = A(str);
            A += StringEditor.RemoveSpace;
            Console.WriteLine($"{A.Method.Name}: {A(str)}");
            str = A(str);
        }
    }
}
namespace laba11
{
    internal interface MyInterface
    {
        void MethodInterface();
    }
    internal class SomeClass : MyInterface
    {
        private int _myFieldPrivate;
        public int _myFieldPublic;
        private int MyPropertyPrivate
        {
            get { return _myFieldPrivate; }
        }
        public int MyPropertyPublic
        {
            get { return _myFieldPublic; }
        }
        private SomeClass(int a) { }
        public SomeClass() { }
        public SomeClass(string a) { }
        public void myPublicMethod()
        {
            Console.WriteLine("Я public метод!");
        }
        private void myPrivateMethod()
        {
            Console.WriteLine("Я private метод!");
        }
        public void MethodInterface()
        {
            Console.WriteLine("Метод от интерфейса!");
        }
        public void ExampleDouble(double a, double b, double c)
        {
            Console.WriteLine("Метод с параметров double");
            Console.WriteLine($"Сумма всех элементов: {a + b + c}");
        }
    }
}

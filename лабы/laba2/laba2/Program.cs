namespace laba2
{
    partial class ValidationOfInformation
    {
        public static bool CheckRealeaseYear(int realeaseYear){
            if (realeaseYear < 1885 || realeaseYear > 2022)
                return false;
            return true;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Car a = new Car();
        }
    }
}
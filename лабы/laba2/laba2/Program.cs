namespace laba2
{
    class Override
    {
        private readonly string _brand;
        public Override(string brand)
        {
            _brand = brand;
        }
        public override int GetHashCode()
        {
            int hash = 0;
            Random rand = new Random();
            for (int i = 0; i < _brand.Length; i++)
            {
                hash += _brand[i];
            }
            hash *= rand.Next(1000, 999999);
            return (int)Math.Abs(hash * _brand.Length);
        }
        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }
        public override string ToString()
        {
            return _brand;
        }
    }

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
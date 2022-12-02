using System.Collections;

namespace laba9
{
    public interface ISet<T>
    {
        void Add(T item);
        void Delete(T item);
        void Search(T item);
        void ShowCollection();
    }

    internal class MyCollection<T> : ISet<T>
    {
        private ArrayList items = new ArrayList();

        public void Add(T item)
        {
            items.Add(item);
        }

        public void Delete(T item)
        {
            items.Remove(item);
        }
        public void Search(T item)
        {
            if (items.Contains(item))
            {
                Console.WriteLine($"{item} найден");
            }
            else
            {
                Console.WriteLine($"{item} не найден");
            }
        }
        public void ShowCollection()
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
        public IEnumerator GetEnumerator() => items.GetEnumerator();
    }
}

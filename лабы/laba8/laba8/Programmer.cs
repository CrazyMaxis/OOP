namespace laba8
{
    internal class Programmer
    {
        public delegate void Action(List<string> list);
        public event Action delete;
        public event Action mutate;

        public void Delete(List<string> list)
        {
            Console.Write("Ведите номер элемента, который хотите удалить(начиная с 0): ");
            int num = int.Parse(Console.ReadLine());
            list.RemoveAt(num);
            delete?.Invoke(list);
        }

        public void Mutate(List<string> list)
        {
            Random random = new Random();
            List<string> NewList = list.OrderBy(item => random.Next()).ToList();
            list.Clear();
            list.AddRange(NewList);
            mutate?.Invoke(list);
        }
    }
}

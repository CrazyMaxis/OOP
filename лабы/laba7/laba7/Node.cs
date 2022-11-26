namespace laba7
{
    class Node<T>
    {
        Node<T> next;
        public T Info;
        public Node<T> Next;
    }
    static class StaticOperations
    {
        public static int Count<T>(List<T> list) where T : class
        {
            int count = 0;
            Node<T> curr = list.Head;
            while (curr != null)
            {
                count++;
                curr = curr.Next;
            }
            return count;
        }
    }
}

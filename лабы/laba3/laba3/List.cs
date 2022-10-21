namespace laba3
{
    internal class List
    {
        Node tail;
        Node head;
        int length;
        public List()
        {
            tail = null;
            head = null;
            length = 0;
        }
        public Node Head
        {
            get => head;
        }
        public void AddNode(string info)
        {
            Node node = new Node();
            node.Info = info;
            if (head == null)
            {
                head = node;
            }
            else
            {
                tail.Next = node;
            }
            tail = node;
            length++;
        }
        public void ShowInfo()
        {
            Node node = head;
            while (node != null)
            {
                Console.WriteLine(node.Info);
                node = node.Next;
            }
        }
    }
}

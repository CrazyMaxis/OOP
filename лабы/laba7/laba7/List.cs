using System.Collections.Generic;

namespace laba7
{
    interface IList<T>
    {
        void AddNode(T info);
        void ShowInfo();
        void DeleteNode(T info);

    }

    class List<T>: IList<T>
    {
        Node<T> tail;
        Node<T> head;
        int length;
        public List()
        {

            tail = null;
            head = null;
            length = 0;
        }
        public Node<T> Head
        {
            get => head;
        }

        public void AddNode(T info)
        {
            Node<T> node = new Node<T>();
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
        public void FoundNode(T info)
        {
            Node<T> curr = head;
            Node<T> prev = null;
            bool flag = false;
            while (curr != null)
            {
                if (curr.Info.Equals(info))
                {
                    Console.WriteLine(curr.Info);
                    flag = true;
                }
                prev = curr;
                curr = curr.Next;
            }
            if (!flag) throw new DeleteNotFounded("Элемент не найден");
        }
        public void DeleteNode(T info)
        {
            Node<T> curr = head;
            Node<T> prev = null;
            bool flag = false;
            while (curr != null)
            {
                if (curr.Info.Equals(info))
                {
                    if (prev != null)
                    {
                        prev.Next = curr.Next;
                        if (curr.Next == null)
                            tail = prev;
                    }
                    else
                    {
                        head = head.Next;

                        if (head == null)
                            tail = null;
                    }
                    flag = true;
                }
                prev = curr;
                curr = curr.Next;
            }
            if (!flag) throw new DeleteNotFounded("Элемент для удаления не найден");
        }
        public void ShowInfo()
        {
            Node<T> node = head;
            while (node != null)
            {
                Console.WriteLine(node.Info.ToString());
                node = node.Next;
            }
        }
    }
}

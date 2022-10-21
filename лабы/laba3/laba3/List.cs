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
                Console.Write(node.Info);
                node = node.Next;
            }
            Console.WriteLine();
        }

        public static List operator +(List list1, List list2)
        {
            Node curr2 = list2.head;
            while (curr2 != null)
            {
                list1.tail.Next = curr2;
                list1.tail = curr2;
                curr2 = curr2.Next;
                list1.length++;
            }

            return list1;
        }

        public static List operator --(List list)
        {
            list.head = list.head.Next;
            list.length--;
            return list;
        }

        public static bool operator ==(List list1, List list2)
        {
            if (list1.length != list2.length)
            {
                return false;
            }

            Node curr1 = list1.head;
            Node curr2 = list2.head;

            while (curr1 != null)
            {
                if (curr1.Info != curr2.Info)
                {
                    return false;
                }

                else
                {
                    curr1 = curr1.Next;
                    curr2 = curr2.Next;
                }
            }
            return true;
        }

        public static bool operator !=(List list1, List list2)
        {
            return !(list1 == list2);
        }

        public static bool operator true(List list1)
        {
            if (list1.head == null)
                return true;
            else
                return false;
        }

        public static bool operator false(List list1)
        {
            if (list1.head == null)
                return false;
            else
                return true;
        }

        Production Product = new Production(199, "БЕЛАЗ"); // вложенный объект
        internal class Production
        {
            private int _id;
            private string _nameOfOrganization;

            public Production(int id, string nameOfOrganization)
            {
                _id = id;
                _nameOfOrganization = nameOfOrganization;
            }

            public int Id
            {
                get
                {
                    return _id;
                }
                set
                {
                    _id = value;
                }
            }

            public string NameOfOrganization
            {
                get
                {
                    return _nameOfOrganization;
                }
                set
                {
                    _nameOfOrganization = value;
                }
            }
        }

        
    }
}

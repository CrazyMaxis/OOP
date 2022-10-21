using System.Security.Cryptography;

namespace laba3
{
    internal class List
    {
        private Node tail;
        private Node head;
        private int length;

        public List()
        {
            tail = null;
            head = null;
            length = 0;
        }

        public Node Head
        {
            get { return head; }
            set { head = value; }
        }

        public int Length
        {
            get { return length; }
            set { length = value; }
        }

        public void AddNode(string info)
        {
            Node node = new Node();
            node.Info = info;

            if (head == null)
                head = node;
            else
                tail.Next = node;

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

        public void Copy(List list)
        {
            head = list.head;
            tail = list.tail;
            length = list.length;
        }

        public static List operator +(List list1, List list2)
        {
            Node curr = list2.head;
            List list3 = new List();
            list3.Copy(list1);

            while (curr != null)
            {
                list3.tail.Next = curr;
                list3.tail = curr;
                curr = curr.Next;
                list3.length++;
            }

            return list3;
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
                return false;

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
                get { return _id; }
                set { _id = value; }
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

        public class Developer
        {
            int _id;
            string _nameOfDeveloper;
            string _department;

            public Developer(int id, string name, string otdel)
            {

                _id = id;
                _nameOfDeveloper = name;
                _department = otdel;
            }

            public int Id
            {
                get { return _id; }
                set { _id = value; }
            }

            public string NameOfDeveloper
            {
                get { return _nameOfDeveloper; }
                set { _nameOfDeveloper = value; }
            }

            public string Department
            {
                get { return _department; }
                set { _department = value; }
            }
        }
    }
}

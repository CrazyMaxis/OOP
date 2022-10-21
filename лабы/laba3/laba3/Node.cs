using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace laba3
{
    class Node
    {
        private string inf;
        private Node next;
        public string Info
        {
            get => inf;
            set => inf = value;
        }
        public Node Next
        {
            get => next;
            set => next = value;
        }
    }

    static internal class StaticOperations
    {
        public static string getSumString(List list)
        {
            string str = "";
            Node curr = list.Head;

            while (curr != null)
            {
                str = str + curr.Info;
                curr = curr.Next;
            }

            return str;
        }

        public static int LongestInfo(List list)
        {
            Node curr = list.Head;
            string str = curr.Info;
            string str2 = curr.Info;

            while (curr != null)
            {
                if (curr.Info.Length > str.Length)
                    str = curr.Info;
                else
                    str2 = curr.Info;
                curr = curr.Next;
            }

            int a = str.Length;
            int b = str2.Length;
            a -= b;
            return a;
        }

        public static int Count(List list)
        {
            int count = 0;
            Node curr = list.Head;

            while (curr != null)
            {
                count++;
                curr = curr.Next;
            }

            return count;
        }
    }

    static class Extensions
    {
        public static int GetLastNumber(this List list)
        {
            Node curr = list.Head;
            int buf = 0;
            while (curr != null)
            {
                if (curr.Info[0] > '0' && curr.Info[0] < '9')
                {
                    buf = curr.Info[0] - '0';
                }
                curr = curr.Next;
            }
            return buf;
        }

        public static void DeleteAnyElement(this List list, string s)
        {
            Node curr = list.Head;
            while (curr != null)
            {
                if (curr.Info == s)
                {
                   while (curr != null)
                        curr = curr.Next;
                }
                list.Length--;
                curr = curr.Next;
                return;
            }
            curr = curr.Next;
        }
    }
}

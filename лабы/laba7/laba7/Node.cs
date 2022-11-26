using System.Collections.Generic;
using System.Text;

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
        public static void ReadFile(List<Cake> collection, string patch)
        {
            string[] textFile = System.IO.File.ReadAllLines(patch);
            for (int i = 0; i < textFile.Length; i++)
            {
                string[] dwordLine = textFile[i].Split(' ');
                switch (dwordLine[0])
                {
                    case "Cake":
                        collection.AddNode(new Cake(Convert.ToInt32(dwordLine[1]), Convert.ToInt32(dwordLine[2]), dwordLine[3], dwordLine[4]));
                        break;
                }
            }
        }
        public static void InFile(List<Cake> list, string patch)
        {
            Node<Cake> node = list.Head;
            string str2 = "";
            using (StreamWriter sw = new StreamWriter(patch, false, Encoding.Default))
            {
                while (node != null)
                {
                    if (node.Info is Cake)
                    {
                        sw.WriteLine(node.Info.ToString() + " " + node.Info.Price + " " + node.Info.Weight + " " + node.Info._name + " " + node.Info.Factory);
                        node = node.Next;
                    }
                }

            }
        }
    }
    class DeleteNotFounded : Exception
    {
        public DeleteNotFounded(string message) : base(message) { }
    }
}

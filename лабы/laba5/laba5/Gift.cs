using System.Diagnostics.Metrics;
using System.Drawing;
using System.Reflection;

namespace laba5
{
    partial class Flower
    {
        public override string ToString()
        {
            return "Это цветок\0";
        }

        public void Buy()
        {
            if (_amount != 0)
            {
                Console.WriteLine("Вы купили цветок.");
                _amount--;
            }
            else
            {
                Console.WriteLine("Недостаточно цветков для продажи.");
            }
        }
    }

    class Gift
    {
        private readonly List<Pastry>? ListPastry;
        public List<Pastry>? GetList
        {
            get;
            set;
        }

        public Gift()
        {
            ListPastry = new List<Pastry>();
        }

        public void addPastry(Pastry obj)
        {
            ListPastry.Add(obj);
        }

        public bool removePastry(int position)
        {
            if (position < ListPastry.Count)
            {
                Console.WriteLine($"Элемент {position} удалён");
                ListPastry.RemoveAt(position - 1);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Show()
        {
            Console.WriteLine("----Список----"); 
            foreach (Pastry obj in ListPastry)
            {
                Console.WriteLine($"{obj} {obj.Weight}");
            }
            Console.WriteLine("--------------");
            Console.WriteLine();
        }
        public System.Collections.IEnumerator GetEnumerator()
        {
            return ListPastry.GetEnumerator();
        }
    }
    //class Controller
    //{
    //    public static int GiftPrice(Gift ListPastry)
    //    {
    //        int price = 0;
    //        int size = 0;
    //        int counter = 0;

    //        foreach (var i in ListPastry)
    //        {
    //            size++;
    //        }

    //        Pastry[] arr = new Pastry[size];
    //        foreach (Pastry i in ListPastry)
    //        {
    //            arr[counter] = i;
    //            price += arr[counter].Price;
    //            counter++;
    //        }

    //        return price;
    //    }

    //    public static Gift WeightSort(Gift ListPastry)
    //    {
    //        int size = 0;
    //        int counter = 0;

    //        foreach (var i in ListPastry)
    //        {
    //            size++;
    //        }

    //        Pastry[] arr = new Pastry[size];
    //        foreach (Pastry i in ListPastry)
    //        {
    //            arr[counter] = i;
    //            counter++;
    //        }

    //        Pastry temp;
    //        for (int i = 0; i < arr.Length - 1; i++)
    //        {
    //            for (int j = 0; j < arr.Length - i - 1; j++)
    //            {
    //                if (arr[j].Weight > arr[j + 1].Weight)
    //                {
    //                    temp = arr[j];
    //                    arr[j] = arr[j + 1];
    //                    arr[j + 1] = temp;
    //                }
    //            }
    //        }

    //        Gift Gift = new Gift();

    //        for (int i = 0; i < arr.Length; i++)
    //        {
    //            Gift.addPastry(arr[i]);
    //        }
    //        return Gift;
    //    }
    //    public static string FindMinWeight(Gift ListPastry)
    //    {
    //        int minWeight = 999999999;
    //        string component = null;

    //        foreach (Pastry i in ListPastry)
    //        {
    //            if (i.Weight < minWeight)
    //            {
    //                minWeight = i.Weight;
    //                component = i.ToString();
    //            }
    //        }
    //        return component;
    //    }
    //}
        //public static void ReadFile(ChildrensGift collection, string patch)
        //{
        //    string[] textFile = System.IO.File.ReadAllLines(patch);
        //    for (int i = 0; i < textFile.Length; i++)
        //    {
        //        string[] dwordLine = textFile[i].Split(' ');
        //        switch (dwordLine[0])
        //        {
        //            case "CandyBox":
        //                collection.addCandy(new CandyBox(dwordLine[1], Convert.ToInt32(dwordLine[2]), Convert.ToInt32(dwordLine[3]), Convert.ToInt32(dwordLine[4]), dwordLine[5]));
        //                break;
        //            case "Caramel":
        //                collection.addCandy(new Caramel(dwordLine[1], Convert.ToInt32(dwordLine[2]), Convert.ToInt32(dwordLine[3]), Convert.ToInt32(dwordLine[4]), dwordLine[5]));
        //                break;
        //            case "ChocolateCandy":
        //                collection.addCandy(new ChocolateCandy(dwordLine[1], Convert.ToInt32(dwordLine[2]), Convert.ToInt32(dwordLine[3]), Convert.ToInt32(dwordLine[4]), Convert.ToInt32(dwordLine[5])));
        //                break;
        //            case "Cookie":
        //                collection.addCandy(new Cookie(dwordLine[1], Convert.ToInt32(dwordLine[2]), Convert.ToInt32(dwordLine[3]), Convert.ToInt32(dwordLine[4]), Convert.ToBoolean(dwordLine[5])));
        //                break;
        //        }
        //    }
        //}
}

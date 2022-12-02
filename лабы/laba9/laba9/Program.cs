using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace laba9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Image DaVinchi = new Image("Картина ДаВинчи");
            Image Mikilanjelo = new Image("Черепашка ниндзя");
            Image Morgenshetrn = new Image("Пыль");
            Image LenDumat = new Image("Что-то");

            MyCollection<Image> images = new MyCollection<Image>() { DaVinchi, Mikilanjelo, Morgenshetrn, LenDumat };

            images.ShowCollection();
            Console.WriteLine();
            images.Delete(Mikilanjelo);
            images.ShowCollection();
            Console.WriteLine();
            images.Search(Morgenshetrn);
            images.Add(Mikilanjelo);
            images.ShowCollection();
            Console.WriteLine();

            LinkedList<int> Numbers = new LinkedList<int>();

            for (int i = 0; i < 5; i++)
            {
                Numbers.AddLast(i * 2);
                Numbers.AddFirst((i * 2) + 1);
            }

            Console.Write("Вывод списка:");
            DisplayList(Numbers);

            Numbers.RemoveFirst();
            Numbers.RemoveLast();

            Console.Write("Вывод списка после удаление в конце и в начале:");
            DisplayList(Numbers);

            int n = 2;
            int m = 5;
            for (int i = n; i < m; i++)
            {
                Numbers.Remove(i);
            }

            Console.Write("Вывод списка после удаление последовательности:");
            DisplayList(Numbers);


            LinkedListNode<int> a = Numbers.AddLast(11);
            Numbers.AddBefore(a, 118);
            Numbers.AddAfter(a, 18);

            Console.Write("Вывод списка:");
            DisplayList(Numbers);

            LinkedList<int> Numbers2 = Numbers;
            Console.Write("Вывод второго списка:");
            DisplayList(Numbers2);

            int x = 118;
            foreach (int i in Numbers2)
            {
                if (i == x)
                    Console.WriteLine("Нашел");
            }

            ObservableCollection<Image> obsPlant = new ObservableCollection<Image>() { DaVinchi, Mikilanjelo, Morgenshetrn, LenDumat };
            Console.WriteLine();
            obsPlant.CollectionChanged += ObsPlantChanged;
            Image newImage = new Image("Z");
            obsPlant.Add(newImage);
            obsPlant.Remove(LenDumat);
            Console.ReadKey();

            void DisplayList(LinkedList<int> collection)
            {
                foreach (int i in collection)
                {
                    Console.Write(" {0}", i);
                }
                Console.WriteLine();
            }
        }
        private static void ObsPlantChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    {
                        Image images = e.NewItems[0] as Image;
                        Console.WriteLine($"Элемент {images._type} был добавлен");
                        break;
                    };
                case NotifyCollectionChangedAction.Remove:
                    {
                        Image images = e.OldItems[0] as Image;
                        Console.WriteLine($"Элемент {images._type} был удален");
                        break;
                    }
            }
        }
    }
}
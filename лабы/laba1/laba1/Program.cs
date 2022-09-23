using System;   // подключено пространство имен System, но с последних версий не нужно подключать
using System.Text;

/*
    № 1 Основы CLR и .NET. Типы. Массивы, кортежи и строки
*/

namespace laba1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 Задание
            // Числовые типы (целочисленные)
            Console.WriteLine("Введите переменную типа Byte");
            byte bvalue = 0;        // минимальное значение 0, максимальное 255, размер 1 байт
            bvalue = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Byte: " + bvalue);

            Console.WriteLine("Введите переменную типа Sbyte");
            sbyte sbvalue = 127;    // минимальное значение -128, максимальное 127, размер 1 байт
            sbvalue = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine("Sbyte: " + sbvalue);

            Console.WriteLine("Введите переменную типа Int16");
            short svalue = -32768;  // минимальное значение -32768, максимальное 32767, размер 2 байта
            svalue = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Int16: " + svalue);

            Console.WriteLine("Введите переменную типа UInt16");
            ushort usvalue = 0;     // минимальное значение 0, максимальное 65535, размер 2 байта
            usvalue = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("UInt16: " + usvalue);

            Console.WriteLine("Введите переменную типа Int32");
            int ivalue = -2147483648;   // минимальное значение -2^32, максимальное 2^32-1, размер 4 байта
            ivalue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Int32: " + ivalue);

            Console.WriteLine("Введите переменную типа UInt32");
            uint uivalue = 0;           // минимальное значение 0, максимальное 2^33-1, размер 4 байта
            uivalue = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("UInt32: " + uivalue);

            Console.WriteLine("Введите переменную типа Int64");
            long lvalue = -9223372036854775808; // минимальное значение -2^64, максимальное 2^64-1, размер 8 байт
            lvalue = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Int64: " + lvalue);

            Console.WriteLine("Введите переменную типа UInt64");
            ulong ulvalue = 0;                  // минимальное значение 0, максимальное 2^65-1, размер 8 байт
            ulvalue = Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine("UInt64: " + ulvalue);

            Console.WriteLine("Введите переменную типа IntPTR)");
            nint nivalue = -2147483648;
            nivalue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("IntPTR: " + nivalue);

            Console.WriteLine("Введите переменную типа UIntPTR");
            nuint nuivalue = 0;
            nuivalue = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("UIntPTR: " + nuivalue);

            // Числовые типы (с плавающей запятой)

            Console.WriteLine("Введите переменную типа Single");
            float fvalue = -3.40282347E+38F;            // размер 4 байта
            fvalue = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Single: " + fvalue);

            Console.WriteLine("Введите переменную типа Double");
            double dvalue = -1.7976931348623157E+308;   // размер 8 байт
            dvalue = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ваши введенные данные: " + dvalue);

            Console.WriteLine("Введите переменную типа Decimal");
            decimal devalue = -7;                       // размер 16 байт
            devalue = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Ваши введенные данные: " + devalue);

            // Логический тип

            Console.WriteLine("Введите переменную типа Boolean");
            bool bovalue = false;   // true or false, размер 1 байт
            bovalue = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Ваши введенные данные: " + bovalue);

            // Символьные типы 
            Console.WriteLine("Введите переменную типа Char");
            char cvalue = ' ';      // таблица кодировки Юникод, размер 2 байта
            cvalue = Convert.ToChar(Console.ReadLine()); ;
            Console.WriteLine("Ваши введенные данные: " + cvalue);

            Console.WriteLine("Введите переменную типа String");
            string stvalue = "   ";     // размер каждого символа 2 байта
            stvalue = Console.ReadLine();
            Console.WriteLine("Ваши введенные данные: " + stvalue); // контакенация

            // Особые типы
            Console.WriteLine("Введите переменную типа Object");
            object ovalue = 5;
            ovalue = Console.ReadLine();
            Console.WriteLine("Ваши введенные данные: " + fvalue);

            Console.WriteLine("Введите переменную типа Dynamic");
            dynamic dyvalue = 5;
            dyvalue = Console.ReadLine();
            Console.WriteLine("Ваши введенные данные: " + dyvalue);

            // явные преобразования

            int buf = (int)bvalue;
            int buf2 = (int)lvalue;
            short buf3 = (short)bvalue;
            ushort buf4 = (ushort)cvalue;
            byte buf5 = (byte)sbvalue;

            // неявные преобразования

            int implict = cvalue;
            double implict2 = fvalue;
            decimal implict3 = ivalue;
            int implict4 = svalue;
            float implict5 = bvalue;

            // упаковка

            int variable = 255;
            object packing = variable;

            // распаковка

            int unpacking = (int)packing;


            // неявно типизированные переменные

            var ivar = 5;
            var fvar = new float[9];
            var svar = "Hello World!!!";
            Console.WriteLine("Введите неявно типизированную переменную(цифру): ");
            var shvar = Convert.ToInt16(Console.ReadLine());

            // Nullable переменная

            string str = null;
            object nullablevar = null;
            dynamic nullablevar2 = null;

            Nullable<int> nullableint = null;
            short? nullableshort = null;
            Console.WriteLine(nullableshort.HasValue);
            Console.WriteLine(nullableint ?? 0);
            // varaible.Value; // ошибка


            int first = 24;
            int? result = first + nullableint;
            bool firstboo = nullableint > first;
            bool firstboo2 = nullableint < first;
            bool firstboo3 = nullableint == first;

            // присвоение var другого типа

            // ivar = 5.3;  - ошибка


            // 2 Задание
            // Строки

            string str1 = "Line first";
            string str2 = "Line second";

            // Сравнение строк

            if (str1.Length > str2.Length)
            {
                Console.WriteLine("str1 < str2");
            }

            else if (str1.Length < str2.Length)
            {
                Console.WriteLine("str2 > str1");
            }

            else
            {
                Console.WriteLine("str1 == str2");
            }

            int comparestr = String.Compare(str1, str2); // -1

            // сцепление, копирование, выделение подстроки, разделение строки на слова .....

            string Line1 = "Привет    Мир!!!";
            string Line2 = "Меня зовут Максим Поздняков";
            string Line3 = "Мир";

            string Line00 = Line1 + Line3; // сцепление
            string Line01 = String.Concat(Line1, Line3);
            string Line02 = String.Join(' ', Line1, Line2, Line3);

            string Line10 = (string)Line1.Clone(); // копирование
            string Line11 = String.Copy(Line1); // устаревшее
            char[] arr = new char[8];
            Line1.CopyTo(0, arr, 0, 7);

            string Line20 = Line1.Substring(0, 5); // выделение подстроки
            Console.WriteLine(Line1.Contains(Line3));

            string[] Line30 = Line1.Split(' ', StringSplitOptions.RemoveEmptyEntries); // разделение на слова

            string Line40 = Line2.Insert(0, Line3); // вставка подстроки в заданную позицию

            string Line50 = Line2.Remove(0, 5); // удаление подстроки

            Console.WriteLine($"Вы вводили значения: Decimal - {devalue}"); // интерполирование строк

            // метод String.IsNullOrEmpty

            string Line60 = null;
            string Line61 = " ";

            Console.WriteLine(String.IsNullOrEmpty(Line60)); // true
            Console.WriteLine(String.IsNullOrEmpty(Line61)); // false
            Console.WriteLine(String.IsNullOrWhiteSpace(Line61)); // true

            // StringBuilder

            var text = new StringBuilder("Hello, World!!! My name's Maxim", 60);
            text.Remove(13, 2);
            text.Insert(0, "Mister, ");
            text.Replace("Maxim", "Максим");
            text.Append(", I am programmer");


            // 3 Задание
            // Массивы

            int[,] matrix = new int[3, 3] { { 0, 1, 2 },
                                            { 3, 4, 5 },
                                            { 6, 7, 8 } };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Массив string

            string[] arrSTR = new string[5] { "Петя", "Nikita", "Katya", "Masha", "Sasha" };
            foreach (string s in arrSTR)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine("Длина массива{0}", arrSTR.Length);
            Console.WriteLine("Выберите элемент, который надо поменять: ");
            int check = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Введите строку: ");
            arrSTR[check] = Console.ReadLine();

            // Ступенчатый(зубчатый) массив

            float[] Arr01 = new float[2];
            float[] Arr02 = new float[3];
            float[] Arr03 = new float[4];
            float[][] Arr00 = new float[3][] { Arr01, Arr02, Arr03 };
            for (int i = 0; i < Arr00.Length; i++)
            {
                for (int j = 0; j < Arr00[i].Length; j++)
                {
                    Console.WriteLine("Y: {0} X: {1}", i, j);
                    Arr00[i][j] = int.Parse(Console.ReadLine());
                }
            }

            // Неявно типизированный массив

            var Arr20 = new[] { 1, 2, 3 };
            var Arr21 = new[] { "Yashnii", "Karebo", "Tarakanov" };
        }
    }
}
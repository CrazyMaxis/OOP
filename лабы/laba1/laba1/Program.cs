using System;   // подключено пространство имен System, но с последних версий не нужно подключать

/*
    № 1 Основы CLR и .NET. Типы. Массивы, кортежи и строки
*/

namespace laba1
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
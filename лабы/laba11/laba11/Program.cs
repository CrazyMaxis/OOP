using System.IO;
using System.Reflection;
using System.Text;

namespace laba11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "laba11.SomeClass";
            SomeClass obj1 = new SomeClass();
            using (StreamWriter sw = new StreamWriter(@"Reflection.txt", false, Encoding.Default))
            {
                sw.WriteLine("- - - - - определение имени сборки - - - - -");
                sw.WriteLine(Reflector.GetAssemblyName());
                sw.WriteLine("- - - - - публичные конструкторы - - - - -");
                sw.WriteLine(Reflector.HasPublicConstructors(name));
                sw.WriteLine("- - - - - все общедоступные публичные методы - - - - -");
                Reflector.PublicMethods(name, sw);
                sw.WriteLine("- - - - - информация о полях и свойствах класса - - - - -");
                Reflector.FieldsAndProperties(name, sw);
                sw.WriteLine("- - - - - все реализованные классом интерфейсы - - - - -");
                Reflector.Interfaces(name, sw);
                sw.WriteLine("- - - - - выводит по имени класса имена методов - - - - -");
                Reflector.MethodType(name, "Double", sw);
                sw.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - -");
                string methodName;
                string parametrs;
                using (StreamReader reader = new StreamReader("Invoke.txt", Encoding.Default))
                {
                    methodName = reader.ReadLine();
                    parametrs = reader.ReadLine();
                }
                string[] arrParm = parametrs.Split(' ');
                int countParm = 0;
                for (int i = 0; i < arrParm.Length; i++)
                {
                    if (arrParm[i] != "")
                        countParm++;
                }
                object[] param = new object[countParm];
                for (int i = 0; i < countParm; i++)
                {
                    param[i] = Convert.ToDouble(arrParm[i]);
                }
                Reflector.Invoke(obj1, methodName, param);
                sw.WriteLine(Reflector.Create(obj1).ToString());
                sw.WriteLine("///////////////////////////////////////////////////////////");
            }
        }
    }
}
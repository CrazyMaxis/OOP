using System.Reflection;

namespace laba11
{
    static class Reflector
    {
        public static string GetAssemblyName()
        {
            return typeof(Program).Assembly.GetName().FullName;
        }

        public static bool HasPublicConstructors(string name)
        {
            Type type = Type.GetType(name, false, true);
            foreach (var item in type.GetConstructors())
            {
                if (item.IsPublic)
                {
                    return true;
                }
            }
            return false;
        }

        public static IEnumerable<string> PublicMethods(string name, StreamWriter sw)
        {
            List<string> list = new List<string>();
            Type type = Type.GetType(name, false, true);
            foreach (MethodInfo method in type.GetMethods())
            {
                if (method.IsPublic)
                {
                    list.Add(method.Name);
                    sw.WriteLine(method.Name);
                }
            }
            return list;
        }
        public static IEnumerable<string> FieldsAndProperties(string name, StreamWriter sw)
        {
            List<string> list = new List<string>();
            Type type = Type.GetType(name, false, true);
            foreach (var item in type.GetFields())
            {
                list.Add(item.Name);
                sw.WriteLine(item.Name);
            }
            foreach (var item in type.GetProperties())
            {
                list.Add(item.Name);
                sw.WriteLine(item.Name);
            }
            return list;
        }
        public static IEnumerable<string> Interfaces(string name, StreamWriter sw)
        {
            List<string> list = new List<string>();
            Type type = Type.GetType(name, false, true);
            foreach (var item in type.GetInterfaces())
            {
                list.Add(item.Name);
                sw.WriteLine(item.Name);
            }
            return list;
        }
        public static void MethodType(string name, string param, StreamWriter sw)
        {
            Type type = Type.GetType(name);

            var bf = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance;

            var collectionMethod = type.GetMethods(bf);


            foreach (MethodInfo method in collectionMethod)
            {
                var collectionParameters = method.GetParameters();
                for (int i = 0; i < collectionParameters.Length; i++)
                {
                    if (collectionParameters[i].ParameterType.Name == param)
                    {
                        sw.WriteLine(method);
                    }
                }
            }
        }
        
    }
}

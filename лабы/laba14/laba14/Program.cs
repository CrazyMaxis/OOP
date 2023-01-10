using System.Diagnostics;

namespace laba14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Инфо Процессов:");
            var allProcesses = Process.GetProcesses();
            Console.Write("{0,-10}", "ID:");
            Console.Write("{0,-40}", "Process Name:");
            Console.Write("{0,-10}", "Priority:\n");
            foreach (var process in allProcesses)
            {
                Console.Write("{0,-10}", $"{process.Id}");
                Console.Write("{0,-40}", $"{process.ProcessName}");
                Console.Write("{0,-10}", $"{process.BasePriority}");
                Console.WriteLine();
            }

            Console.WriteLine("\n\n\nИнфо домена:");
            var thisAppDomain = Thread.GetDomain();

            Console.WriteLine($"Name:  {thisAppDomain.FriendlyName}");
            Console.WriteLine($"Setup Information:  {thisAppDomain.SetupInformation.ToString()}");
            Console.WriteLine("Assemblies:");

            foreach (var item in thisAppDomain.GetAssemblies())
            {
                Console.WriteLine("    " + item.FullName.ToString());
            }

            //AppDomain domen = AppDomain.CreateDomain("Domen");
            //domen.Load("Assembly");
            //AppDomain.Unload(domen);

            Thread simpleThread = new Thread(new ParameterizedThreadStart(Potoki.printNumb));
            simpleThread.Start(8);
            Console.WriteLine("Приоритет: {0}", $"{simpleThread.Priority}");
            Console.WriteLine("Имя: {0}", $"{simpleThread.Name}");
            Console.WriteLine("Числовой ID: {0}", $"{simpleThread.ManagedThreadId}");
            simpleThread.Join();


            Console.WriteLine("СНАЧАЛА НЕЧЕТНЫЕ, ПОТОМ ЧЕТНЫЕ:");
            Potoki.DoItConsistently();
            Thread.Sleep(4000);

            Console.WriteLine("\nОДНО НЕЧЕТНОЕ, ОДНО ЧЕТНОЕ:");
            Potoki.DoItOneByOne();
            Thread.Sleep(4000);

            TimerCallback timerCallback = new TimerCallback(WhatTimeIsIt);
            Timer timer = new Timer(timerCallback, null, 0, 1000);
            Thread.Sleep(5000);

            void WhatTimeIsIt(object obj)
            {
                Console.WriteLine($"It's {DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
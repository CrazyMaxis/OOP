namespace laba12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PMILog.Path = "C:\\Users\\USER\\Desktop\\labs\\3сем\\ооп\\laba12\\laba12\\pmilogfile.txt";

                PMIDiskInfo.FreeMemory();
                PMIDiskInfo.WriteFileSystem();
                PMIDiskInfo.WriteGlobalInf();

                PMIFileInfo.PathToFile = "C:\\Users\\USER\\Desktop\\labs\\3сем\\ооп\\12_Потоки_файловая система.pdf";
                PMIFileInfo.WriteFullPath();
                PMIFileInfo.WriteFulInf();
                PMIFileInfo.WritrDopInf();

                PMIDirInfo.PathToDirectory = "C:\\Users\\USER\\Desktop\\labs\\3сем\\ооп\\laba12";
                PMIDirInfo.WriteCountFile();
                PMIDirInfo.WriteTimeCreation();
                PMIDirInfo.WriteCountPodDir();
                PMIDirInfo.WriteParentDir();

                PMIFileManager.Z5a("C:\\");
                PMIFileManager.Z6b("C:\\Users\\USER\\Desktop\\labs\\3сем\\ооп\\laba12");
                PMIFileManager.Z6c("C:\\PMIInspect2");

                string FileData;
                using (StreamReader file2 = new StreamReader("C:\\Users\\USER\\Desktop\\labs\\3сем\\ооп\\laba12\\laba12\\pmilogfile.txt"))
                {
                    int i = 0;
                    FileData = file2.ReadToEnd();
                    file2.Close();
                }
                string FileDay = "";
                string FileTime = "";
                string FileWord = "";
                string keyWord = "Свободное";
                foreach (var word in FileData.Split('\n'))
                {
                    if (word.Contains("10.01.2023"))
                    {
                        FileDay += word;
                    }
                }
                foreach (var word in FileData.Split('\n'))
                {
                    if (word.Contains("0:"))
                    {
                        FileTime += word;
                    }
                }
                foreach (var word in FileData.Split('\n'))
                {
                    if (word.Contains(keyWord))
                    {
                        FileWord += word;
                    }
                }
                Console.WriteLine($"По дню:\n {FileDay}");
                Console.WriteLine($"По промежутку:\n {FileTime}");
                Console.WriteLine($"По ключевому слову:\n {FileWord}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
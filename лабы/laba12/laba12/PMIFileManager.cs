using System.IO.Compression;

namespace laba12
{
    internal class PMIFileManager
    {
        private static string _path = PMILog.Path;
        private static string _nameDisk;
        public static string NameDisk
        {
            set { _nameDisk = value; }
        }
        public static void Z5a(string nameDisk)
        {
            DriveInfo drive = new DriveInfo(nameDisk);
            if (drive == null)
            {
                throw new Exception("No path to file.");
            }
            File.AppendAllText(_path, $"{DateTime.Now} Выполнение задания Z5A\n");
            var listFiles = Directory.GetFiles(nameDisk);
            var listCat = Directory.GetDirectories(nameDisk);
            Directory.CreateDirectory(nameDisk + "\\PMIInspect");
            File.AppendAllText(nameDisk + "\\PMIInspect\\PMIdirinfo.txt", "Файлы: ");
            foreach (var a in listFiles)
            {
                File.AppendAllText(nameDisk + "\\PMIInspect\\PMIdirinfo.txt", a + " ");
            }
            File.AppendAllText(nameDisk + "\\PMIInspect\\PMIdirinfo.txt", "\nДиректории: ");
            foreach (var a in listCat)
            {
                File.AppendAllText(nameDisk + "\\PMIInspect\\PMIdirinfo.txt", a + " ");
            }
            File.Copy(nameDisk + "\\PMIInspect\\PMIdirinfo.txt", nameDisk + "\\PMIInspect\\PMIdirinfo2.txt");
            File.Delete(nameDisk + "\\PMIInspect\\PMIdirinfo.txt");
        }
        public static void Z6b(string directory)
        {
            if (!Directory.Exists(directory))
            {
                throw new Exception("No path to file.");
            }
            File.AppendAllText(_path, $"{DateTime.Now} Выполнение задания Z5b\n");
            int size = 0;
            Directory.CreateDirectory("C:\\PMIFiles");
            foreach (var file in Directory.GetFiles(directory))
            {
                if ((new FileInfo(file)).Extension == ".docx")
                {
                    string pth = $"C:\\PMIFiles\\copy{size++}.docx";
                    (new FileInfo(file)).CopyTo(pth);
                }
            }
            (new DirectoryInfo("C:\\PMIFiles")).MoveTo("C:\\PMIInspect2"); //Move("C:\\PMIFiles", "C:\\PMIInspect");
        }
        public static void Z6c(string nameFolder)
        {
            File.AppendAllText(_path, $"{DateTime.Now} Выполнение задания Z5c\n");
            ZipFile.CreateFromDirectory(nameFolder, "MyZip.zip");

            ZipFile.ExtractToDirectory("MyZip.zip", "C:\\" + "MyZipFolder");
        }
    }
}

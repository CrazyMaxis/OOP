namespace laba12
{
    internal static class PMILog
    {
        private static string _path;
        public static string Path
        {
            set { _path = value; }
            get
            {
                File.AppendAllText(_path, $"{DateTime.Now}\n");
                return _path;
            }
        }
    }
}

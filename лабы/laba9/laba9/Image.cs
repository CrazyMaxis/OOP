namespace laba9
{
    internal class Image
    {
        public string _type;
        public Image(string type)
        {
            _type = type;
        }

        public override string ToString()
        {
            return _type;
        }
    }
}

namespace laba6
{
    class NullCollectionException : Exception
    {
        public NullCollectionException(string message) : base(message) { }
    }
    class MaxCollection : OverflowException
    {
        public MaxCollection(string message) : base(message) { }
    }
    class DeleteNullObject : Exception
    {
        public DeleteNullObject(string message) : base(message) { }
    }
    class TestNullClass : NullReferenceException
    {
        public TestNullClass(string message) : base(message) { }
    }
}
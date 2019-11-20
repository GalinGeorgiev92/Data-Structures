namespace LinkedStack
{
    public partial class LinkedStack<T>
    {
        private class StackNode
        {
            public T Value { get; set; }

            public StackNode Next { get; set; }

            public StackNode(T value, StackNode next)
            {
                this.Value = value;
                this.Next = next;
            }
        }
    }
}

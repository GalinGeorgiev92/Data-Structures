using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LinkedStack
{
    public class LinkedStack<T> : IEnumerable<T>
    {
        public int Count { get; set; }
        private StackNode top;

        public void Push(T element)
        {
            this.top = new StackNode(element, this.top);

            this.Count++;
        }

        public T Pop()
        {
            if(this.Count == 0)
            {
                throw new InvalidOperationException();
            }

            T result = this.top.Value;
            this.top = this.top.Next;
            this.Count--;

            return result;
        }

        public T Peek()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException();
            }

            return this.top.Value;
        }

        public T[] ToArra()
        {
            T[] array = new T[this.Count];

            StackNode current = this.top;
            int index = this.Count - 1;

            while(current != null)
            {
                array[index--] = current.Value;
                current = current.Next;
            }

            return array;
        }

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

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

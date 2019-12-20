using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReversedList
{
    public class ReversedList<T> : IEnumerable<T>
    {
        private const int InitialSize = 2;
        private T[] items;

        public ReversedList()
        {
            this.items = new T[InitialSize];
        }

        public int Count { get; private set; }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= this.Count)
                {
                    throw new ArgumentOutOfRangeException();
                }

                return this.items[index];
            }
            set
            {
                if (index < 0 || index >= this.Count)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.items[index] = value;
            }
        }

        public void Add(T item)
        {
            if (this.Count == this.items.Length)
            {
                this.Resize();
            }

            this.items[this.Count++] = item;
        }

        private void Resize()
        {
            T[] copy = new T[this.items.Length * 2];
            for (int i = 0; i < this.items.Length; i++)
            {
                copy[i] = this.items[i];
            }

            this.items = copy;
        }

        public T RemoveAt(int index)
        {
            if (index >= this.Count)
            {
                throw new ArgumentOutOfRangeException();
            }

            T element = this.items[index];

            this.items[index] = default(T);
            this.Shift(index);

            if (this.Count <= this.items.Length / 4)
            {
                this.Shrink();
            }

            this.Count--;
            return element;
        }

        private void Shrink()
        {
            T[] copy = new T[this.items.Length / 2];

            for (int i = 0; i < this.items.Length; i++)
            {
                copy[i] = this.items[i];
            }

            items = copy;
        }

        private void Shift(int index)
        {
            for (int i = index; i < this.Count; i++)
            {
                this.items[i] = this.items[i + 1];
            }
        }


        public IEnumerator<T> GetEnumerator()
        {
            return items.ToList().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}

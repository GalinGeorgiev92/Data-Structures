using System;
using System.Collections.Generic;
using System.Text;

namespace CumstomArray
{
    public class CustomArray<T>
    {
        private T[] data;

        public CustomArray()
        {
            this.data = new T[4];
        }

        public int Length { get; private set; } = 4;

        public T this[int index]
        {
            get
            {
                if (index >= this.Length || index < 0)
                {
                    throw new IndexOutOfRangeException();
                }

                return this.data[index];
            }

            set
            {
                if (index >= this.Length || index < 0)
                {
                    throw new IndexOutOfRangeException();
                }

                this.data[index] = value;
            }
        }

        public void Add(int position, T item)
        {
            if (position < 0 || position >= this.data.Length)
            {
                throw new ArgumentOutOfRangeException();
            }

            this.data[position] = item;
        }

        public string ToString()
        {
            var result = string.Empty;

            for (int i = 0; i < data.Length; i++)
            {
                result += this.data[i];
            }

            return result;
        }

        public string GetType()
        {
            var result = this.data.GetType();
            return result.ToString();
        }
    }
}

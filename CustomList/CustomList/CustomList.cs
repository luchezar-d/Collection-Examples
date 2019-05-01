using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        private T[] buffer;
        private int size;
        private const int MIN = 4;

        public CustomList()
        {
            buffer = null;
            size = 0;
        }

        public int Size => size;
        public int Catapcity => buffer.Length;

        public void AddToTheEnd(T value)
        {
            if (buffer == null)
            {
                buffer = new T[MIN];
            }
            else
            {
                if (size == buffer.Length)
                {
                    Expand(size * 2);
                }
            }
            buffer[size] = value;
            ++size;
        }
        public void Expand(int newSize)
        {
            if (newSize < size)
            {
                return;
            }
            var newBuffer = new T[newSize];

            for (int i = 0; i < size; i++)
            {
                newBuffer[i] = buffer[i];
            }

            buffer = newBuffer;
        }
        public void RemoveFromTheEnd()
        {
            if (size == 0)
            {
                throw new IndexOutOfRangeException("Removing from empty list"); 
            }
            
            --size;
            buffer[size] = default(T);
        }
        public void ShrinkToFit()
        {
            Expand(size);
        }

        public void Clear()
        {
            size = 0;
            buffer = new T[MIN];
        }

        public T this[int index]
        {
            get
            {
                return buffer[index];
            }
            set
            {
                buffer[index] = value;
            }
        }
        public T Last
        {
            get
            {
                return buffer[size - 1];
            }
            set
            {
                buffer[size - 1] = value;
            }
        }
        
    }
}

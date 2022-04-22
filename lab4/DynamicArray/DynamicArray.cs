using System.Collections;

namespace DynamicArray
{
    public class DynamicArray<T> : ICollection<T>, IEnumerator<T>, IDisposable
    {
        private T[]? array;
        private int count;
        private int index = -1;
        

        public DynamicArray()
        {
            array = new T[0];                       
        }

        public DynamicArray(int capacity) : this()
        {
            array = new T[capacity];
            count = capacity;
        }
        
        public T? this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value;
            }
        }

       public int Capacity
        {
            get
            {
                return array.Length;
            }
        }

        public virtual T Current
        {
            get
            {
                try
                {
                    return (T)array[index];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
        }




        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public void Add(T item)
        {
            if (array.Length == count)
            {
                T[] newArray = new T[array.Length + 1];
                Array.Copy(array, newArray, array.Length);
                array = newArray;
            }
            array[count] = item;
            count++;
        }
       

        public void Clear()
        {
            array = new T[0];
            count = 0;
        }

        public virtual bool Contains(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (array[i].Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            Array.Copy(this.array, array, this.array.Length);
        }

        public virtual IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (array[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }

        public void Insert(int index, T item)
        {
            if (index < 0 || index > count)
            {
                throw new IndexOutOfRangeException();
            }
            if (array.Length == count)
            {
                T[] newArray = new T[array.Length + 1];
                Array.Copy(array, newArray, array.Length);
                array = newArray;
            }
            Array.Copy(array, index, array, index + 1, count - index);
            array[index] = item;
            count++;
        }

        public void ChangeAt(int index, T item)
        {
            if (index < 0 || index > count)
            {
                throw new IndexOutOfRangeException();
            }
            array[index] = item;    
        }

        public bool Remove(T item)
        {
            int index = IndexOf(item);
            if (index == -1)
            {
                return false;
            }
            array = array.Where((val, idx) => idx != index).ToArray();
            count--;
            return true;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException();
            }
            array = array.Where((val, idx) => idx != index).ToArray();
            count--;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Dispose()
        {                       
            GC.SuppressFinalize(this);
        }

        public bool MoveNext()
        {
            index++;
            return (index < count);
        }

        public void Reset()
        {
            index = -1;
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < count; i++)
            {
                result += array[i] + " ";                          
            }
            return result;
        }

        public T[] ToArray()
        {
            T[] result = new T[count];
            Array.Copy(array, result, count);
            return result;
        }

        public void Sort()
        {
            Array.Sort(array, 0, count);
        }

    }
}
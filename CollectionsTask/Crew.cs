using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using CollectionsTask.Properties;

namespace CollectionsTask
{
    public class Crew: IList
    {
        private readonly object[] contents = new object[8];
        private int count;
        
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return contents[i];
            }
        }
        
        public void CopyTo(Array array, int index)
        {
            int j = index;
            for (int i = 0; i < Count; i++)
            {
                array.SetValue(contents[i], j);
                j++;
            }
        }

        public int Count => count;
        public object SyncRoot => null;
        public bool IsSynchronized => false;
        public int Add(object value)
        {
            if (count < contents.Length)
            {
                contents[count] = value;
                count++;
                var d = contents.Length;

                return (count - 1);
            }
            return -1;
        }
        public bool Contains(object value)
        {
            return IndexOf(value) != -1;
        }
        public void Clear()
        {
            count = 0;
        }
        public int IndexOf(object value)
        {
            for (int i = 0; i < Count; i++)
                if (contents[i] == value)
                    return i;
            return -1;
        }

        public void Insert(int index, object value)
        {
            if ((count + 1 <= contents.Length) && (index < Count) && (index >= 0))
            {
                count++;

                for (int i = Count - 1; i > index; i--)
                {
                    contents[i] = contents[i - 1];
                }
                contents[index] = value;
            }
        }

        public void Remove(object value)
        {
            RemoveAt(IndexOf(value));
        }

        public void RemoveAt(int index)
        {
            if ((index >= 0) && (index < Count))
            {
                for (int i = index; i < Count - 1; i++)
                    contents[i] = contents[i + 1];

                count--;
            }
        }

        public object this[int index]
        {
            get
            {
                return contents[index];
            }
            set
            {
                contents[index] = value;
            }
        }

        public bool IsReadOnly => false;
        public bool IsFixedSize => true;

        public void Sort()
        {
            List<object> list = contents.OfType<object>().ToList();
            list.Sort(new Worker().Compare);
           
            for (int i = 0; i < list.Count; i++)
            {
                this[i] = list[i];
            }
        }
        
    }
}
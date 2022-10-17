using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_oop
{
    class TreeEnum<T> : IEnumerator
        where T : IComparable<T>
    {
        public T[] data;
        int pos = -1;

        public TreeEnum(T[] info)
        {
            data = info;
        }

        public bool MoveNext()
        {
            ++pos;
            return (pos < data.Length);
        }

        public void Reset()
        {
            pos = -1;
        }

        object IEnumerator.Current
        {
            get => Current;
        }

        public T Current
        {
            get 
            {
                try 
                {
                    return data[pos];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}

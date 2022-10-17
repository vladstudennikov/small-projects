using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_oop
{
    class TreeEnumerator<T> : IEnumerable
        where T : IComparable<T>
    {
        private T[] li;
        public TreeEnumerator(T[] li)
        {
            this.li = li;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public TreeEnum<T> GetEnumerator()
        {
            return new TreeEnum<T>(li);
        }
    }
}

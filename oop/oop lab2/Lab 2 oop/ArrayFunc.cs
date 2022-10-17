using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_oop
{
    class ArrayFunc
    {
        private String[] array_test = new String[30];
        private int filled_pos;

        public bool Add(String el)
        {
            if (filled_pos == 30)
            {
                return false;
            }
            array_test[filled_pos] = el;
            filled_pos++;
            return true;
        }

        public bool Delete(int index)
        {
            if (index > filled_pos)
            {
                return false;
            }

            for (int i = index; i < this.filled_pos - 1; i++)
            {
                array_test[i] = array_test[i + 1];
            }
            array_test[this.filled_pos] = null;
            this.filled_pos--;
            return true;
        }

        public String[] returnElements()
        {
            String[] el = new String[this.filled_pos];
            for (int i = 0; i < this.filled_pos; i++)
            {
                el[i] = array_test[i];
            }
            return el;
        }

        public String returnElement(int index)
        {
            if (index > this.filled_pos)
            {
                return new String("Cannot get this element");
            }
            return array_test[index];
        }
    }
}

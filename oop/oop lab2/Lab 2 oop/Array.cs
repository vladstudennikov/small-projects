using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_oop
{
    class Array
    {
        private String[] array_ex = new String[50];
        private byte filled_positions = 0;

        public String[] Array_ex
        {
            get => array_ex;
        }

        public bool Add(String el)
        {
            if (filled_positions == 50)
            {
                return false;
            }
            array_ex[filled_positions] = el;
            filled_positions++;
            return true;
        }
    }
}

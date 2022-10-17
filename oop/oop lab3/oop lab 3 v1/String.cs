using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Runtime.Serialization;

namespace oop_lab_3_v1
{
    [Serializable]
    public class String : IComparable<String>
    {
        private string string_ex;
        public int Length
        {
            get => String_ex.Length;
        }

        public string String_ex
        {
            get => string_ex;

            //check whether there are only letters and numbers in a string
            set
            {
                char[] symbols = "!@#$%^&*()_-+=-*.,><|:".ToCharArray();
                foreach (char letter in value.ToCharArray())
                {
                    foreach (char symbol in symbols)
                    {
                        if (letter.Equals(symbol))
                        {
                            string_ex = "Check input";
                            return;
                        }
                    }
                }
                string_ex = value;
            }
        }

        public String() { }

        public String(string name)
        {
            String_ex = name;
        }

        public string numberSubstring()
        {
            if (String_ex.Equals("Check input")) return "String is incorrect. Please, check it to use functions";

            char[] symbols = "123456890".ToCharArray();
            string res = "";
            foreach (char symbol in symbols)
            {
                foreach (char letter in String_ex)
                {
                    if (symbol == letter) res += letter;
                }
            }
            return res;
        }

        public string charSubstring()
        {
            if (String_ex.Equals("Check input")) return "String is incorrect. Please, check it to use functions";

            char[] symbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            string res = "";
            foreach (char symbol in symbols)
            {
                foreach (char letter in String_ex)
                {
                    if (letter == symbol) res += letter;
                }
            }
            return res;
        }

        public string Regroup()
        {
            string s1 = this.numberSubstring();
            string s2 = this.charSubstring();

            return s2 + s1;
        }

        public int CompareTo(String str)
        {
            if (str is null) throw new ArgumentException("Invalid parameter");
            return str.Length - this.Length;
        }

        public override string ToString()
        {
            return this.String_ex;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4_oop
{
    class Program
    {
        delegate string occuranceOfLetter(string s, char symbol);

        static void cleared(object sender, EventArgs e)
        {
            Console.WriteLine("\nQueue was cleared!");
        }

        static void Main(string[] args)
        {
            //anonymous methos
            occuranceOfLetter count = delegate (string s, char symbol)
            {
                char[] letters = s.ToCharArray();
                int i = 0;
                foreach (char c in letters)
                {
                    if (c == symbol)
                    {
                        ++i;
                    }
                }

                return $"Quantity of {symbol}: {i}";
            };

            string result = count("Hello world!", 'l');
            Console.WriteLine(result);

            //lambda-expression
            occuranceOfLetter count2 = (string s, char symbol) =>
            {
                char[] letters = s.ToCharArray();
                int i = 0;
                foreach (char c in letters)
                {
                    if (c == symbol)
                    {
                        ++i;
                    }
                }

                return $"Quantity of {symbol}: {i}";
            };

            Console.WriteLine(count2("hello world!", 'l'));

            //events with queue
            Queue<int> test = new Queue<int>();

            //testing the queue
            test.Add(2);
            test.Add(4);
            test.Add(6);
            test.Add(8);

            Console.WriteLine("\nQueue:");
            foreach (int n in test.returnQueue())
            {
                Console.WriteLine(n);
            }

            test.Delete();
            Console.WriteLine("\nQueue after deleting of the element:");
            foreach (int n in test.returnQueue())
            {
                Console.WriteLine(n);
            }

            //add the function cleared - it will print that queue was cleared in console 
            test.wasCleared += cleared;

            //when we clear queue test - in console will apper the result of function creared()
            test.Clear();
        }
    }
}

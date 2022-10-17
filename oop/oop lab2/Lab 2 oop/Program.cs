using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_oop
{
    class Program
    {
        //For checking of the tree I wrote a small recursive function that will output binary tree on a screen
        //I have not included this function to BinaryTreeClass because it is needed to separate business logic and outputing information
        public static void PrintTree(TreeNode<String> node, bool leaf = true, string indent = "")
        {
            Console.Write(indent);
            if (leaf)
            {
                Console.Write("└");
                indent += " ";
            }
            else
            {
                Console.Write("├");
                indent += "│";
            }

            Console.WriteLine(node.Data.ToString());

            if (node.Left != null)
            {
                PrintTree(node.Left, node.Right == null, indent);
            }
            if (node.Right != null)
            {
                PrintTree(node.Right, true, indent);
            }
        }

        static void Main(string[] args)
        {
            //Demonstrating class
            Console.WriteLine("==============================\nTask 1 - creation of the class\n");
            String a = new String("HelloWorld");
            String a5 = new String("HelloW");
            String a1 = new String("HelloWorld1");
            String a2 = new String("Helloworld10");
            String a3 = new String("Hel154low4578orld");
            String a4 = new String("Helloworld108798");
            Console.WriteLine("Some functions from String class:");
            Console.WriteLine(a3.numberSubstring());
            Console.WriteLine(a3.charSubstring());
            Console.WriteLine(a3.Regroup());

            //Demonstrating list (from System.Collections.Generic)
            Console.WriteLine("==============================\n\nTask 2 - list and array");
            List<String> test = new List<String>();
            //Demonstrating of adding of the elements
            test.Add(a);
            test.Add(a1);
            test.Add(a2);
            Console.WriteLine("\nList after adding elements:");
            foreach (String el in test)
            {
                Console.WriteLine(el.String_ex);
            }

            //Demonstrating of deleting of the elements
            test.Remove(a);
            Console.WriteLine("\nNew list (after deleting element:)");
            foreach (String el in test)
            {
                Console.WriteLine(el.String_ex);
            }

            //Demonstrating inserting
            test.Insert(0, a);
            Console.WriteLine("\nNew list (after inserting element:)");
            foreach (String el in test)
            {
                Console.WriteLine(el.String_ex);
            }

            //Demonstrating of navigating through the list (searching for some indexes)
            Console.WriteLine("Index of a: " + test.IndexOf(a));

            Console.WriteLine("==============================\n\nTask 3 - binary tree\n");
            var test1 = new BinaryTree<String>();

            //Adding of some elements
            test1.Add(a1);
            test1.Add(a);
            test1.Add(a2);
            test1.Add(a3);
            test1.Add(a4);
            test1.Add(a5);

            //Check whether the elements is in the tree
            Console.WriteLine(test1.Contains(new String("Not found")));
            Console.WriteLine(test1.Contains(a5));
            Console.WriteLine(test1.Contains(a));

            Console.WriteLine();
            PrintTree(test1.Root);

            //Deleting some elements from the tree and checking whether deleting went sucessfully
            test1.Delete(a5);
            Console.WriteLine();
            PrintTree(test1.Root);
            test1.Delete(a2);
            test1.Add(a5);
            Console.WriteLine();
            PrintTree(test1.Root);

            //Finding some elements in a tree
            Console.WriteLine();
            Console.WriteLine(test1.Find(new String("Not found")).ToString());
            Console.WriteLine(test1.Find(a3));

            //Postorder traversal
            string[] postlist = new string[20];
            test1.Postorder(test1.Root, ref postlist);
            foreach (string el in postlist)
            {
                if (el != null)
                {
                    Console.WriteLine(el);
                }
                else 
                {
                    break;
                }
            }

            //testing ienumerator and ienumerable
            TreeEnumerator<string> test2 = new TreeEnumerator<string>(postlist);
            Console.WriteLine("\n==============================\n\nTesting interfaces ienumerator and ienumerable\n");
            foreach (string el in test2)
            {
                if (el != null)
                {
                    Console.WriteLine(el);

                }
            }
            Console.WriteLine("\n==============================");
        }
    }
}

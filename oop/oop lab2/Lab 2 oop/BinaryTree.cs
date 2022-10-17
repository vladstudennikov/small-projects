using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_oop
{
	class BinaryTree<T> 
		where T : IComparable<T>
	{
		public TreeNode<T> Root;

		public void Add(T element)
		{
			TreeNode<T> elem = new TreeNode<T>(element);

			if (Root == null)
			{
				Root = elem;
				return;
			}

			TreeNode<T> current = Root;
			TreeNode<T> prev = null;
			while (current != null)
			{
				prev = current;

				if (element.CompareTo(current.Data) > 0)
				{
					current = current.Right;
				}
				else
				{
					current = current.Left;
				}
			}

			if (element.CompareTo(prev.Data) > 0)
			{
				prev.Right = elem;
			}
			else
			{
				prev.Left = elem;
			}
		}

		public bool Delete(T element)
		{
			//Find node with the same data in the tree
			TreeNode<T> current = Root;
			TreeNode<T> prev = null;
			bool left = false;
			while (current != null)
			{
				int c = element.CompareTo(current.Data);
				if (c == 0)
				{
					break;
				}

				prev = current;
				if (c > 0)
				{
					current = current.Right;
					left = false;
				}
				else
				{
					current = current.Left;
					left = true;
				}
			}

			// if element is now in the tree - return false
			if (current == null)
			{
				return false;
			}

			// element we delete is the only element
			if (prev == null && current.Left == null && current.Right == null)
			{
				Root = null;
				return true;
			}

			// If element has no children, set the pointer from the parent element to element to null
			if (current.Left == null && current.Right == null)
			{
				if (left)    prev.Left = null;
				else    prev.Right = null;

				return true;
			}
			
			// If element only has one child, create the pointer from parent node to a child
			else if (current.Right == null)
			{
				if (prev == null)
				{
					Root = current.Left;
				}
				else if (left)    prev.Left = current.Left;
				else    prev.Right = current.Left;

				return true;
			}
			else if (current.Left == null)
			{
				if (prev == null)
				{
					Root = current.Right;
				}
				else if (left)    prev.Left = current.Right;
				else    prev.Right = current.Right;

				return true;
			}
			// Node has two children
			else
			{
				TreeNode<T> min = current.Right;
				TreeNode<T> p = current;
				while (min.Left != null)
				{
					p = min;
					min = min.Left;
				}

				current.Data = min.Data;
				if (p == current)
				{
					current.Right = min.Right;
				}
				else
				{
					p.Left = null;
				}

				return true;
			}
		}
		public bool Contains(T element)
		{
			TreeNode<T> node = Find(element);
			if (node == null)
			{
				return false;
			}
			return node.Data.CompareTo(element) == 0;
		}

		public TreeNode<T> Find(T element)
		{
			TreeNode<T> current = Root;
			TreeNode<T> prev = null;
			while (current != null)
			{
				prev = current;

				int c = element.CompareTo(current.Data);

				if (c == 0)
				{
					return current;
				}
				else if (c > 0)
				{
					current = current.Right;
				}
				else
				{
					current = current.Left;
				}
			}

			//return previous element if it is not found
			return prev;
		}

		public int getFilled(string[] ar)
		{
			for (int i = 0; i < ar.Length; ++i)
			{
				if (ar[i] == null) return i;
			}
			return ar.Length;
		}

		public void Postorder(TreeNode<T> n, ref string[] res) 
		{
			if (n == null)    return;

			Postorder(n.Left, ref res);
			Postorder(n.Right, ref res);

			res[this.getFilled(res)] = n.Data.ToString();
		}
	}
}

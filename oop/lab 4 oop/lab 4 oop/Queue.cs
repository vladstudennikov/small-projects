using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4_oop
{
    public class Queue<T>
    {
        private Node<T> first; 
        private Node<T> last; 
        private int count;

        public EventHandler<QueueIsClearedEventArgs> wasCleared;

        public Queue() { }

        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);
            Node<T> tempNode = last;
            last = node;
            if (count == 0)
                first = last;
            else
                tempNode.Next = last;
            count++;
        }
        
        public T Delete()
        {
            if (count == 0)
                throw new InvalidOperationException();
            T output = first.Data;
            first = first.Next;
            count--;
            return output;
        }
        
        //get the first element
        public T First
        {
            get
            {
                if (IsEmpty)
                    throw new InvalidOperationException();
                return first.Data;
            }
        }

        //get the last element
        public T Last
        {
            get
            {
                if (IsEmpty)
                    throw new InvalidOperationException();
                return last.Data;
            }
        }
        public int Count 
        { 
            get => count;  
        }

        public bool IsEmpty 
        { 
            get => count == 0; 
        }

        public void Clear()
        {
            first = null;
            last = null;
            count = 0;

            //working with event
            QueueIsClearedEventArgs args = new QueueIsClearedEventArgs();
            args.isCleared = true;
            QueueWasCleared(args);
        }

        //if we add any functions to the delegate wasCleared - 
        //those functions would be accomplished
        protected virtual void QueueWasCleared(QueueIsClearedEventArgs e)
        {
            EventHandler<QueueIsClearedEventArgs> handler = wasCleared;
            if (handler != null)
            {
                handler.Invoke(this, e);
            }
        }

        public bool Contains(T data)
        {
            Node<T> current = first;
            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            return false;
        }

        public List<T> returnQueue()
        {
            Node<T> current = first;
            List<T> l = new List<T>();

            while (current != null)
            {
                l.Add(current.Data);
                current = current.Next;
            }

            return l;
        }
    }
}

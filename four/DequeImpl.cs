using System;
using System.Collections;
using System.Collections.Generic;

namespace four
{
    public class DequeImpl<T> : Deque<T>
    {
        private int count;
        private DequeElement<T> head;
        private DequeElement<T> tail;

        public void AddFirst(T data)
        {
            DequeElement<T> node = new DequeElement<T>(data);
            DequeElement<T> temp = head;
            node.Next = temp;
            head = node;
            if (count == 0)
            {
                tail = head;
            }
            else
            {
                temp.Previous = node;
            }
            count++;
        }

        public void AddLast(T data)
        {
            DequeElement<T> node = new DequeElement<T>(data);
 
            if (head == null)
                head = node;
            else
            {
                tail.Next = node;
                node.Previous = tail;
            }
            tail = node;
            count++;
        }

        public T DeleteFirst()
        {
            if (count == 0)
                throw new InvalidOperationException();
            T output = head.Data;
            if(count==1)
            {
                head = tail = null;
            }
            else
            {
                head = head.Next;
                head.Previous = null;
            }
            count--;
            return output;
        }

        public T DeleteLast()
        {
            if (count == 0)
                throw new InvalidOperationException();
            T output = tail.Data;
            if (count == 1)
            {
                head = tail = null;
            }
            else
            {
                tail = tail.Previous;
                tail.Next = null;
            }
            count--;
            return output;
        }

        public T First { 
            get {
                if (IsEmpty)
                    throw new InvalidOperationException();
                return head.Data;
            } 
        }
        public T Last { 
            get {
                if (IsEmpty)
                    throw new InvalidOperationException();
                return tail.Data;
            } 
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        public bool IsEmpty
        {
            get { return count == 0; }
        }
        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public bool Contains(T data)
        {
            DequeElement<T> current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            DequeElement<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }   
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        public void Enqueue(T data)
        {
            AddFirst(data);
        }

        public T Dequeue()
        {
            return DeleteFirst();
        }
    }
} 
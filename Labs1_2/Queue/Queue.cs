using System;
using System.Collections;
using System.Collections.Generic;

namespace Queue
{
    public class Queue<T> : IEnumerable<T>, ICollection
    {
        private QueueNode<T> head;
        private QueueNode<T> tail;
        private int count;
        public Queue(){
            head = null;
            tail = null;
            count = 0;
        }
        public Queue(params T[] nodes)
        {
            foreach (var node in nodes)
            {
                Enqueue(node);
            }
        }
        public Queue(IEnumerable<T> collection)
        {
            foreach(T element in collection)
            {
                Enqueue(element);
            }
        }

        public int Count => throw new NotImplementedException();

        public bool IsSynchronized => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();
            
        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            QueueNode<T> current = head;
            while (current != null)
            {
                yield return current.value;
                current = current.Next;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public void Enqueue(T element)
        {
            QueueNode<T> node = new QueueNode<T>(element);
            QueueNode<T> tempNode = tail;
            tail = node;
            if (count == 0)
                head = tail;
            else
                tempNode.Next = tail;
            count++;
        }
        public T Dequeue()
        {
            if (count == 0)
                throw new InvalidOperationException();
            T output = head.value;
            head = head.Next;
            count--;
            return output;
        }
        public T Peek()
        {
            if(count == 0)
                throw new InvalidOperationException();
            return head.value;
        }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }
        public bool Contains(T element)
        {
            if (element == null) throw new ArgumentNullException("element");
            foreach (T node in this)
            {
                if(node.Equals(element)) return true;
            }
            return false;
        }
    }
}
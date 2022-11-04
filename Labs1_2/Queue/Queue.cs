using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace Queue
{
    public class Queue<T> : IEnumerable<T>, ICollection
    {
        #region Fields
        private QueueNode<T> head;
        private QueueNode<T> tail;
        private int count;
        private object _syncRoot;
        #endregion

        #region Constructors
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
        #endregion

        #region Events
        public event Action<QueueNode<T>> EventEnqueue = delegate { };
        public event Action EventDequeue = delegate { };
        public event Action EventClear = delegate { };

        protected virtual void OnEnqueue(QueueNode<T> element)
        {
            EventEnqueue.Invoke(element);
        }

        protected virtual void OnDequeue()
        {
            EventDequeue.Invoke();
        }

        protected virtual void OnClear()
        {
            EventClear.Invoke();
        }
        #endregion

        #region ICollection
        public int Count => count;

        public bool IsSynchronized => false;

        public object SyncRoot
        {
            get
            {
                Interlocked.CompareExchange(ref _syncRoot, new object(), null);
                return _syncRoot;
            }
        }

        public void CopyTo(Array array, int index)
        {
            if (head == null) throw new ArgumentNullException("empty collection");
            if (array == null) throw new ArgumentNullException("array");
            if (index < 0) throw new ArgumentOutOfRangeException("index");
            if (array.Length - index < count) throw new ArgumentOutOfRangeException("array");

            QueueNode<T> curNode = head;
            while (curNode != null)
            {
                array.SetValue(curNode.value, index++);
                curNode = curNode.Next;
            }
        }
        #endregion

        #region IEnumerable<T>
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
        #endregion

        #region QueueMethods
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
            OnEnqueue(node);
        }
        public T Dequeue()
        {
            if (count == 0)
                throw new InvalidOperationException();
            T output = head.value;
            head = head.Next;
            count--;
            OnDequeue();
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
            OnClear();
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
        #endregion
    }
}
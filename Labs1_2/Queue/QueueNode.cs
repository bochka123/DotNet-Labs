using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    internal class QueueNode<T>
    {
        public T value { get; set; }
        public QueueNode<T> Next { get; set; } = null;
        public QueueNode<T> Previous { get; set; } = null;
        public Queue<T> queue { get; set; }

        public QueueNode(T value)
        {
            this.value = value;
            queue = null;
        }
        public override String ToString()
        {
            return value.ToString();
        }
        public override int GetHashCode()
        {
            return value.GetHashCode();
        }
    }
}

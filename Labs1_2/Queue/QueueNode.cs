using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class QueueNode<T>
    {
        public T Value { get; set; }
        public QueueNode<T> Next { get; set; }
        public QueueNode<T> Previous { get; set; }

        public QueueNode(T value)
        {
            this.Value = value;
        }
        public override String ToString()
        {
            return Value.ToString();
        }
        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
}

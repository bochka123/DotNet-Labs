using NUnit.Framework;
using FluentAssertions;
using Queue;
using System;
using System.Collections;

namespace QueueTests
{
    [Author("Oleksandr Tkach", "sasha2003tkach001100@gmail.com")]
    [TestFixture]
    public class Tests
    {
        //arrange
        //act
        //assert
        [Test]
        public void Constructor_WithElementsButOneElementNull_ArgumentNullException()
        {
            Action action = () => new Queue<String>("Test", "Test", null, "Test");

            action.Should().Throw<ArgumentNullException>();
        }

        [Test]
        public void Constructor_WithNodes()
        {
            Queue<int> queue = new Queue<int>(new QueueNode<int>(6), new QueueNode<int>(4), new QueueNode<int>(1), new QueueNode<int>(2));
        }

        [Test]
        public void Constructor_WithNodesButOneElementNull_ArgumentNullException()
        {
            Action action = () => new Queue<int>(new QueueNode<int>(6), null, new QueueNode<int>(1), new QueueNode<int>(2));

            action.Should().Throw<ArgumentNullException>();
        }

        [Test]
        public void Constructor_WithIEnumarableCollection()
        {
            System.Collections.Generic.List<int> list = new System.Collections.Generic.List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            Queue<int> queue = new Queue<int>(list);
        }

        [Test]
        public void Constructor_WithIEnumarableCollectionButOneElementNull_ArgumentNullException()
        {
            System.Collections.Generic.List<String> list = new System.Collections.Generic.List<String>();
            list.Add("Test");
            list.Add("Test");
            list.Add(null);

            Action action = () => new Queue<string>(list);

            action.Should().Throw<ArgumentNullException>();
        }

        [Test]
        public void EventEnqueue_AddElementToCollectionAndMonitorEventIsRaisedAndArgCorrect_EventISRaisedArgCorrect()
        {
            Queue<int> queue = new();
            using var monitoredEvents = queue.Monitor();
            int expected = 7;

            queue.Enqueue(expected);

            monitoredEvents.Should().Raise("EventEnqueue")
                .WithSender(queue)
                .WithArgs<QueueNode<int>>(args => args.Value == expected);
        }

        [Test]
        public void EventDequeue_RemoveElementFromCollectionAndMonitorEventIsRaisedAndArgCorrect_EventISRaisedArgCorrect()
        {
            Queue<int> queue = new(6, 4, 1, 2);
            using var monitoredEvents = queue.Monitor();
            int expected = 6;

            queue.Dequeue();

            monitoredEvents.Should().Raise("EventDequeue")
                .WithSender(queue)
                .WithArgs<QueueNode<int>>(args => args.Value == expected);
        }

        [Test]
        public void EventClear_ClearCollectionAndCheckClearEventIsRaised_EventClearIsRaised()
        {
            Queue<int> queue = new(6, 4, 1, 2);
            using var monitoredEvents = queue.Monitor();

            queue.Clear();

            monitoredEvents.Should().Raise("EventClear");
        }

        [Test]
        public void IsSynchronized_ReturnsFalse()
        {
            Queue<int> queue = new Queue<int>();

            bool actual = queue.IsSynchronized;

            actual.Should().BeFalse();
        }

        [Test]
        public void SyncRoot_ReturnsObjectWhichIsSame()
        {
            Queue<int> queue = new Queue<int>();
            object expected = queue.SyncRoot;

            object actual = queue.SyncRoot;

            actual.Should().Be(expected);
        }

        [Test]
        public void CopyTo_CopyQueueToArray_ArrayEquivalentExpected()
        {
            Queue<int> queue = new Queue<int>(6, 4, 1, 2);
            Array actual = new int[queue.Count];
            Array expected = new int[] { 6, 4, 1, 2 };

            queue.CopyTo(actual, 0);

            actual.Should().BeEquivalentTo(expected);
        }

        [Test]
        public void CopyTo_CopyQueueToArrayButQueueIsEmpty_ArgumentNullException()
        {
            Queue<int> queue = new Queue<int>();
            Array actual = new int[queue.Count];

            Action action = () => queue.CopyTo(actual, 0);

            action.Should()
                .Throw<ArgumentNullException>()
                .WithParameterName("empty collection");
        }

        [Test]
        public void CopyTo_CopyQueueToArrayButArrayNull_ArgumentNullException()
        {
            Queue<int> queue = new Queue<int>(6, 4, 1, 2);
            Array actual = null;

            Action action = () => queue.CopyTo(actual, 0);

            action.Should()
                .Throw<ArgumentNullException>()
                .WithParameterName("empty array");
        }

        [Test]
        public void CopyTo_CopyQueueToArrayButIndexLessZero_ArgumentOutOfRangeException()
        {
            Queue<int> queue = new Queue<int>(6, 4, 1, 2);
            Array actual = new int[queue.Count];

            Action action = () => queue.CopyTo(actual, -1);

            action.Should()
                .Throw<ArgumentOutOfRangeException>()
                .WithParameterName("index below zero");
        }

        [Test]
        public void CopyTo_CopyQueueToArrayButArrayLengthLessThanCount_ArgumentOutOfRangeException()
        {
            Queue<int> queue = new Queue<int>(6, 4, 1, 2);
            Array actual = new int[1];

            Action action = () => queue.CopyTo(actual, 0);

            action.Should()
                .Throw<ArgumentOutOfRangeException>()
                .WithParameterName("small length of array");
        }


        [Test]
        public void GetEnumerator()
        {
            Queue<int> queue = new(6, 4, 1, 2);

            foreach (int i in queue) { }
        }

        [Test]
        public void IEnumerableGetEnumerator()
        {
            Queue<int> queue = new();
            IEnumerable test = queue;

            foreach (int i in test) { }
        }

        [Test]
        public void Enqueue_AddElement_TailEqualsNodeValue()
        {
            var queue = new Queue<int>();
            int expected = 7;

            queue.Enqueue(7);
            int actual = queue.Peek();

            actual.Should().Be(expected);
        }

        [Test]
        public void Enqueue_AddQueueNode_TailEqualsNodeValue()
        {
            var queue = new Queue<int>();
            int expected = 7;
            var node = new QueueNode<int>(7);

            queue.Enqueue(node);
            int actual = queue.Peek();

            actual.Should().Be(expected);
        }

        [Test]
        public void Enqueue_AddQueueNodeButQueueIsEmpty_TailEqualsNodeValue()
        {
            var queue = new Queue<int>();
            int expected = 7;
            var node = new QueueNode<int>(7);

            queue.Enqueue(node);
            int actual = queue.Peek();

            actual.Should().Be(expected);
        }

        [Test]
        public void Enqueue_AddQueueNodeButQueueNodeNull_ArgumentNullException()
        {
            var queue = new Queue<int>(6, 4, 1, 2);
            QueueNode<int> node = null;
            
            Action action = () => queue.Enqueue(node);

            action.Should()
                .Throw<ArgumentNullException>()
                .WithParameterName("node");
        }

        [Test]
        public void Dequeue_DeletingFirstElement_ReturnEqualsDeleted()
        {
            var queue = new Queue<int>(6, 4, 1, 2);
            int expected = 6;

            int actual = queue.Dequeue();

            actual.Should().Be(expected);
        }

        [Test]
        public void Dequeue_DeletingFirstElement_NextEqualsHead()
        {
            var queue = new Queue<int>(6, 4, 1, 2);
            int expected = 4;
            int actual = 0;

            queue.Dequeue();
            actual = queue.Peek();

            actual.Should().Be(expected);
        }

        [Test]
        public void Dequeue_DeletingFirstElementButQueueIsEmpty_InvalidOperationException()
        {
            var queue = new Queue<int>();

            Action action = () => queue.Dequeue();

            action.Should().Throw<InvalidOperationException>();
        }

        [Test]
        public void Peek_PeekElementOfQueue_PeekEuqualsToLast()
        {
            var queue = new Queue<int>(6, 4, 1, 2);
            int expected = 6;

            int actual = queue.Peek();

            actual.Should().Be(expected);
        }

        [Test]
        public void Peek_PeekWhenQueueIsEmpty_InvalidOperationException()
        {
            var queue = new Queue<int>();

            Action action = () => queue.Peek();

            action.Should().Throw<InvalidOperationException>();
        }

        [Test]
        public void Clear_CleringQueue_QueueIsEmptyAndCount0()
        {
            var queue = new Queue<int>(6, 4, 1, 2);
            int expectedCount = 0;

            queue.Clear();

            queue.Should()
                .BeEmpty().And
                .HaveCount(expectedCount);
        }

        [Test]
        public void Contains_CheckIfQueueContainsElement_TrueExpected()
        {
            var queue = new Queue<int>(6, 4, 1, 2);

            bool actual = queue.Contains(1);

            actual.Should().BeTrue();
        }

        [Test]
        public void Contains_CheckIfQueueContainsElement_FalseExpected()
        {
            var queue = new Queue<int>(6, 4, 1, 2);

            bool actual = queue.Contains(7);

            actual.Should().BeFalse();
        }

        [Test]
        public void Contains_CheckIfQueueContainsElementButQueueIsEmpty_ArgumentNullException()
        {
            var queue = new Queue<String>();
            String s = null;

            Action action = () => queue.Contains(s);

            action.Should()
                .Throw<ArgumentNullException>()
                .WithParameterName("element");
        }

        [Test]
        public void QueueNodeConstructor_Previous()
        {
            QueueNode<int> node1 = new QueueNode<int>(5);
            QueueNode<int> node2 = new QueueNode<int>(6);

            node1.Previous = node2;
            node2.Next = node1;

            node1.Previous.Should().Be(node2);
        }

        [Test]
        public void ToString_StringValueOfNodeValueExpected()
        {
            QueueNode<int> node = new QueueNode<int>(5);
            String expected = "5";

            String actual = node.ToString();

            actual.Should().Be(expected);
        }

        [Test]
        public void GetHashCode_HashCodeValueOfNodeValueExpected()
        {
            QueueNode<int> node = new QueueNode<int>(7);
            int expected = 7;

            int actual = node.GetHashCode();

            actual.Should().Be(expected);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace GenericStack
{
    internal class StackTestsUsingSinglyTests
    {
        [Test]
        public void Push_EmptyStack_NotEmpty()
        {
            var st = new GenericStackUsingSingly<int>();

            st.Push(54);
            st.Push(54);

            Assert.That(st.IsEmpty, Is.False);
            Assert.That(st.Peek(), Is.EqualTo(54));

        }

        [Test]

        public void Push_NonEmptyStack_NotEmpty()
        {
            var st = new GenericStackUsingSingly<int>();

            st.Push(4);
            st.Push(5);
            st.Push(63);

            st.Push(77);

            Assert.That(st.IsEmpty, Is.False);
            Assert.That(st.Peek(), Is.EqualTo(77));
        }

        [Test]
        public void Pop_StackElement_ShouldBeEmptyCheckPopped()
        {
            var st = new GenericStackUsingDoubly<int>();
            st.Push(4);

            var x = st.Pop();

            Assert.That(st.IsEmpty, Is.False);
            Assert.That(st.Peek(), Is.EqualTo(77));
        }

        [Test]

        public void GetEnumerator_GIvenStack_VerifySequence()
        {
            var st = new GenericStackUsingSingly<int>();
            st.Push(4);
            st.Push(5);
            st.Push(63);
            st.Push(77);

            string sequence = "";
            foreach (int i in st)
            {
                Console.Write($"{i}, ");
                sequence += $"{i}, ";
            }


            Assert.That(st.IsEmpty, Is.False);
            Assert.That(st.Peek(), Is.EqualTo(77));
            Assert.That(sequence, Is.EqualTo("77, 63, 5, 4, "));
        }
    }
}

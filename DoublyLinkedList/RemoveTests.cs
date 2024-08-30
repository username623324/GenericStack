using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace GenericDoublyLinkedList
{
    public class RemoveTests
    {
        [Test]
        public void RemoveFromTailUsingMethodA_ListWith4Nodes_HeadTailNotEqual()
        {
            //Arrange
            var list = new DoublyLinkedList<int>();
            list.AddToTail(1);
            list.AddToTail(2);
            list.AddToTail(3);
            list.AddToTail(4);

            //Act
            list.RemoveFromTail(useMethodB: false);

            //Assert
            Assert.That(list.Head.Data, Is.EqualTo(1));
            Assert.That(list.Tail.Data, Is.EqualTo(3));
            Assert.That(list.Head.Next.Data, Is.EqualTo(2));
            Assert.That(list.Tail.Previous.Data, Is.EqualTo(2));
        }

        [Test]
        public void RemoveFromTailUsingMethodB_ListWith4Nodes_HeadtailNotEqual()
        {
            //Arrange
            var list = new DoublyLinkedList<int>();
            list.AddToTail(1);
            list.AddToTail(2);
            list.AddToTail(3);
            list.AddToTail(4);

            //Act
            list.RemoveFromTail(useMethodB: true);

            //Assert
            Assert.That(list.Head.Data, Is.EqualTo(1));
            Assert.That(list.Tail.Data, Is.EqualTo(3));
            Assert.That(list.Head.Next.Data, Is.EqualTo(2));
            Assert.That(list.Tail.Previous.Data, Is.EqualTo(2));
        }

        [Test]
        public void RemoveFromTailUsingMethodB_ListEmpty_ThrowError()
        {
            //Arrange
            var list = new DoublyLinkedList<int>();
           

            //Act
            
            var act= () => { list.RemoveFromTail(true); };
           

            //Assert
            Assert.That(act, Throws.InvalidOperationException.With.Message.StartWith("List is empty."));

        }
    }
}

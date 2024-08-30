using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    internal class SimplyTests
    {

        [Test]
        public void TestArea()
        {

            var list = new SinglyLinkedList();

            var nodeToAdd = new Node(12);
            var nodeNext = new Node(12);

            nodeToAdd.Next = nodeNext;
            
            list.AddToHead(5);

            Assert.That(list.Head.Data, Is.EqualTo(5));
            Assert.That(list.Tail.Data, Is.EqualTo(5));        
        }

        [Test] 
        
        public void AddToHead_EmptyListAddOneNode_NodeTailEqual() 
        {
            //Arrange
            var list = new SinglyLinkedList();

            //Act
            list.AddToHead(88);

            //Assert

            Assert.That(list.Head.Data, Is.EqualTo(88));
            Assert.That(list.Head, Is.EqualTo(list.Tail));



        }

        [Test]

        public void AddToHead_ListOneNodeAddNode_HeadToTailNotEqual()
        {
            //Arrange

            var list =new SinglyLinkedList();
            list.AddToHead(88);

            //Act
            list.AddToHead(99);
            
            //Assert
            Assert.That(list.Head.Data, Is.EqualTo(99));
            Assert.That(list.Tail.Data, Is.EqualTo(88));
            Assert.That(list.Head, Is.Not.EqualTo(list.Tail));

        }

        [Test]

        public void RemoveFromTail_EmptyList_HeadToTail()
        {
            var list = new SinglyLinkedList();

            Action act = () => list.RemoveFromTail();

            Assert.That(act, Throws.InvalidOperationException.With.Message.StartWith("Linked List Does Not Have Any Nodes"));
        }


        [Test]

        public void RemoveFromTail_ListOneNode_HeadToTailEqualNull()
        {

            var list = new SinglyLinkedList();
            list.AddToHead(1);

            list.RemoveFromTail();

            Assert.That(list.Head, Is.EqualTo(list.Tail));
            Assert.That(list.Head, Is.Null);


        }

        [Test]
        public void RemoveFromTail_List3Node_HeadToTailNotEqual()
        {
            var list = new SinglyLinkedList();
            list.AddToTail(1);
            list.AddToTail(2);
            list.AddToTail(3);

            list.RemoveFromTail();

            Assert.That(list.Head.Data, Is.EqualTo(1));
            Assert.That(list.Tail.Data, Is.EqualTo(2));
            Assert.That(list.Head.Next, Is.EqualTo(list.Tail));
        }
    }

}

using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSingly
{
    internal class AddTest
    {
        [Test]
        public void AddToHead_ListOneNodeAddNode_HeadToTailNotEqual()
        {
            //Arrange

            var list = new SinglyLinkedList<int>();
            list.AddToHead(88);

            //Act
            list.AddToHead(99);

            //Assert
            Assert.That(list.Head.Data, Is.EqualTo(99));
            Assert.That(list.Tail.Data, Is.EqualTo(88));
            Assert.That(list.Head, Is.Not.EqualTo(list.Tail));

        }
    }
}

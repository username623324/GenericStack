using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSingly
{
    internal class AddPersonTest
    {
        [Test]
        public void AddToHead_ListOneNodeAddNode_CompareUsingEquals()
        {
            //Arrange

            var list = new SinglyLinkedList<Person>();
            

            //Act
            var person = new Person("John", 77);
            list.AddToHead(person);

            //Assert
            var other = new Person("John", 77);
            other.School = "Ateneo";


            Assert.That(list.Head.Data.Equals(other), Is.True);
            //Assert.That(list.Head.Data.CompareTo(other), Is.EqualTo(0));
            Assert.That(list.Tail.Data.Age, Is.EqualTo(77));
            
            

        }

        [Test]
        public void AddToHead_ListOneNodeAddNode_CompareUsingCompareTo()
        {
            //Arrange

            var list = new SinglyLinkedList<Person>();


            //Act
            var person = new Person("John", 77);
            list.AddToHead(person);

            //Assert
            var other = new Person("John", 77);
            other.School = "Ateneo";


            // Assert.That(list.Head.Data.Equals(other), Is.True);
            Assert.That(list.Head.Data.CompareTo(other), Is.EqualTo(0));
            Assert.That(list.Tail.Data.Age, Is.EqualTo(77));



        }
    }
}

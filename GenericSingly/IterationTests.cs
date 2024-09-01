using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace GenericSingly
{
    public class IterationTests
    {
        [Test]
        public void UsingForeach_List4Nodes_PrintInSequence()
        {
            var list = new SinglyLinkedList<int>();
            list.AddToTail(1);
            list.AddToTail(2);
            list.AddToTail(3);
            list.AddToTail(4);

            //Act
            var s = string.Empty;
            foreach (var node in list)
            {
                Console.Write($"{node.Data}");
                s += $"{node.Data}";
            }

            //Assert

            Assert.That(s, Is.EqualTo("1234"));

        }

        [Test]
        public void UsingForeach_List4NodesPerson_PrintInSequence()
        {
            var list = new SinglyLinkedList<Person>();
            list.AddToTail(new Person("Matthew", 77));
            list.AddToTail(new Person("SASAS", 33));
            list.AddToTail(new Person("sasasasas", 200));
            list.AddToTail(new Person("P", 20));
            //Act
            var s = string.Empty;
            foreach (var node in list)
            {
                Console.Write($"{node.Data}");
                s += $"{node.Data}";
            }

            //Assert
            
            //Assert.That(s, Is.EqualTo("1234"));

        }



    }
}

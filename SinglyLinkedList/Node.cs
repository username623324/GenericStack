using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SinglyLinkedList
{
    public class Node
    {
        public int Data {  get; set; }
        public Node Next { get; set; }

        public Node(int data)
        {

            Data = data;
        }
    }

    public class SinglyLinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }

       

        public void AddToHead(int data)
        {
            var newNode = new Node(data);
            

            if(Head == null && Tail == null)
            {
                Head = newNode;
                Tail = newNode; 
            }
            else
            {
                newNode.Next = Head;
                Head = newNode;
                
            }
            newNode = null;
        }

        public void AddToTail(int Data)
        {
            var newNode = new Node(Data);
            if(Head == null && Tail == null)
            {

                Head = newNode;
                Tail = newNode;

            }
            else
            {
                Tail.Next = newNode;
                Tail = newNode;
            }
            newNode = null;
        }

        public void RemoveFromHead()
        {
            if(Head == null || Tail == null)
            {
                throw new InvalidOperationException("Linked List Does not have any nodes");
            }
            else if (Head == Tail)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                var temp = Head;
                Head = Head.Next;
                temp.Next = null;
                temp = null;
            }
        }
        public void RemoveFromTail()
        {
            if (Head == null || Tail == null)
            {
                throw new InvalidOperationException("Linked List Does Not Have Any Nodes");
            }
            else if (Head == Tail)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                var temp = Head;
                while(temp.Next != Tail)
                    temp = temp.Next;

                temp.Next = null;
                Tail = temp;    

                temp = null;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    internal class Stack
    {
        //Creating node a top
        public Node top;

        //Implementing push method
        public void Push(int newData)
        {
            Node newNode = new Node(newData);
            if (this.top != null)
            {
                newNode.next = this.top;
            }
            this.top = newNode;
            Console.WriteLine("New Node {0} is added ", newNode.data);
        }

        //Peek method gives the top most element in stack without removing the element.
        public void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("No elements present in the stack");
                return;
            }
            Console.WriteLine("The element after peeking is : " + this.top.data);
        }

        //Pop Method-Removes the top most element
        public void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("No elements present in the stack");
                return;
            }
            Peek();
            this.top = this.top.next;
        }

        //Method to display all the nodes in a stack
        public void Display()
        {
            Node temp = this.top;
            if (temp == null)
            {
                Console.WriteLine("No values have been added");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine("Value in the stack is : " + temp.data);
                temp = temp.next;
            }
        }
    }
}

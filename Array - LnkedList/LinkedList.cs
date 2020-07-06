using Array___LnkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLnkedList
{
    public class LinkedList
    {
        private Node head;
        int max;
        int min;


        public void printAllNodes()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }
    

        public void Add(int data)//AddLast
        {
            if (head == null)
            {
                head = new Node();

                head.data = data;
                head.next = null;
                max = data;
                min = data;
            }
            else
            {
                Node toAdd = new Node();
                toAdd.data = data;
                if (min > data)
                    min = data;
                if (max < data)
                    max = data;

                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                    

                }

                current.next = toAdd;
            }
        }
        public void RemoveLastNode()
        {
            Node current = head;
            Node last = current;
           

            if (head == null)
                return;
            if (head.next == null)
            {
                head = null;
                return;
            }

            while (current.next != null)
            {
                if (current.next.next == null)
                {
                    current.next=current.next.next;
                    return;
                }
                current = current.next;
            }

            
        }
        public void PrintLast()
        {
            Node current = head;
            while (current != null)
            {
               // Console.WriteLine(current.data);
                if (current.next == null)
                    Console.WriteLine(current.data);
                current = current.next;
   
            }
        }

        public void MaxNumber()
        {
            Console.WriteLine($"This is max number { max}");
        }
        public void MinNumber()
        {
            Console.WriteLine($"This is min number {min}");
        }

    }
}

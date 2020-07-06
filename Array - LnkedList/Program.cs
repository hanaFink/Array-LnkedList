using ArrayLnkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array___LnkedList
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("Add Last:");
            LinkedList myList = new LinkedList();

            myList.Add(2);
            myList.Add(2);
            myList.Add(4);

        
            myList.printAllNodes();

            myList.PrintLast();

            myList.MaxNumber();
            myList.MinNumber();
            myList.RemoveLastNode();
            myList.PrintLast();
           


        }
    }
}

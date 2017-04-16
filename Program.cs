using System;
using AlgCSharp.NestedList;
using AlgCSharp.Stack;

namespace AlgCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // MergeSort.MergeSort ms = new  MergeSort.MergeSort();
            // ms.DoMergeSort();  
            // StackFromQueueTest test  = new StackFromQueueTest();
            // test.TestStackFromQueue();
            
            NestedListTest test = new NestedListTest();
            test.TestNestedList();

        }
    }
}

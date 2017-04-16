using System;
using AlgCSharp.NestedList;
using AlgCSharp.Stack;
using AlgCSharp.Triangle;

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
            AlgCSharp.Triangle.MaxTriangles t;
            t = new MaxTriangles(new int[] {6,9,7,10,14,16});
            var ret=t.getMaxTriangles();;

        }
    }
}

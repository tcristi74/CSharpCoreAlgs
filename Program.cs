using System;
using AlgCSharp.BinaryTree;
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
            // AlgCSharp.Triangle.MaxTriangles t;
            // t = new MaxTriangles(new int[] {6,9,7,10,14,16});
            // var ret=t.getMaxTriangles();;

            // Array.IsomorphicWords cls = new Array.IsomorphicWords(new [] {"ave","demo","erty","ert","soso","bobo","gaga"} );
            // cls.CountIsomorphicWords(); 

            SymetricCheck sc = new SymetricCheck();
            //create node
            Node root = new Node();
            root.Value = 1;
            root.Left = new Node();
            root.Left.Value=2;
            root.Left.Left = new Node();
            root.Left.Left.Value = 3;
            root.Left.Right = new Node();
            root.Left.Right.Value = 4;

            root.Right = new Node();
            root.Right.Value=2;
            root.Right.Left = new Node();
            root.Right.Left.Value = 4;
            root.Right.Right = new Node();
            root.Right.Right.Value = 3;

            var ret = sc.CheckSymetric(root);
            Console.WriteLine(ret);

        }
    }
}

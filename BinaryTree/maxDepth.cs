using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgCSharp.BinaryTree {

public class Node {
    public int Value{get;set;}
    public Node Right {get;set;}
    public Node Left {get;set;}

}
    public class MaxDepth {
        public int GetDepth(Node root){

            if (root==null)throw new Exception("empty tree");
            var ret = traverse(root,0);
            return ret;
        }

        private int traverse(Node node, int level)
        {
            if (node==null) return level;
            int l1 = traverse(node.Left,level+1);
            int r1 = traverse(node.Right,level+1);
            return Math.Max(l1,r1);
        }
    }

    [TestClass]
    public class MaxDepthTest {

        [TestMethod]
        public void TestMaxDepth () {
            MaxDepth pr = new MaxDepth();

            // add testing data 
            Node root = new Node();
            root.Value=  10 ;
            root.Left = new Node();
            root.Right = new Node();
            root.Left.Left = new Node();
            root.Left.Right = new Node();
            root.Right.Left = new Node();
            root.Right.Right = new Node();

            root.Right.Left.Left = new Node();
            root.Right.Left.Right = new Node();
           root.Right.Left.Right.Right = new Node();

            var ret=pr.GetDepth(root);

            Assert.AreEqual (ret-1, 4, "values are not equal");
            Console.WriteLine ("----------Max Depth done-------");
        }
    }

}
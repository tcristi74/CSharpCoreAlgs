using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgCSharp.BinaryTree {
    /* 
    Given a binary tree, check whether it is a mirror of itself.
    For example, this binary tree is symmetric:
         1
       /   \
      2     2
     / \   / \
    3   4 4   3
    But the following is not:
        1
       / \
      2   2
       \   \
       3    3
    */

    public class SymetricCheck{

        public bool CheckSymetric(Node root){

                if (root.Left==null && root.Right==null ) return true;
                if (root.Left==null || root.Right==null ) return false;
                return check2Trees(root.Left, root.Right);
                
        }

        private bool check2Trees(Node lNode, Node rNode){
                if (lNode.Value!=rNode.Value) return false;
                if (lNode.Left==null && rNode.Right!=null || 
                    lNode.Right==null && rNode.Left!=null ||
                    lNode.Left!=null && rNode.Right==null || 
                    lNode.Right!=null && rNode.Left==null) return false;   

                bool v1=true;
                bool v2=true;
                if (lNode.Left!=null && rNode.Right!=null)
                    v1=check2Trees(lNode.Left,rNode.Right);      
                if (lNode.Right!=null && rNode.Left!=null)
                    v2=check2Trees(lNode.Right,rNode.Left);
                    
                return  v1 && v2;
        }
    }


  //  [TestClass]
    public class SymetricTest{

        [TestMethod]
        public void TestSymetric(){

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

            root.Left.Left.Left = new Node();
            root.Left.Left.Left.Value=5;


            root.Right = new Node();
            root.Right.Value=2;
            root.Right.Left = new Node();
            root.Right.Left.Value = 4;
            root.Right.Right = new Node();
            root.Right.Right.Value = 3;
            root.Right.Right.Right = new Node();
            root.Right.Right.Right.Value=5;


            var ret=sc.CheckSymetric(root);
            Assert.AreEqual (ret, true, "values are not equal");
            Console.WriteLine ("----------symetric done-------");
            

        }
    }
}
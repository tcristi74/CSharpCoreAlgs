using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgCSharp.Array {

    /*
    Given an array A[] and a number x, check for pair in A[] with sum as x
    Write a program that, given an array A[] of n numbers and another number x, 
    determines whether or not there exist two elements in S whose sum is exactly x

     */

    public class SumOf2 {

        public SumOf2 () { }

        public bool CheckForExistingSum (int[] arr, int x) {
            // order the array first 
            var arrOrdered = arr.OrderBy (p => p).ToList ();

            for (int i = 0; i < arrOrdered.Count; i++) {
                var v1 = arrOrdered[i];
                if (v1 >= x / 2) return false;
                var target = x - v1;
                if (findTargetDirect (target, arrOrdered)) return true;
            }

            return false;
        }

        private bool findTargetDirect (int target, List<int> list) {
            return list.Contains (target);
        }

        private bool findTargetSorted (int target, List<int> list, int position, int start, int end) {

            if (start == end) return false;
            if (target == list[position]) {
                return true;
            }

            if (target > list[position]) {
                return findTargetSorted (target, list, position + (end - position) / 2, position + 1, end);
            } else {
                return findTargetSorted (target, list, (position - start) / 2, start, position - 1);
            }

        }

    }


  //  [TestClass]
    public class SumOf2Test{

        [TestMethod]
        public void TestSumOf2(){

            var t = new SumOf2();
            var ret = t.CheckForExistingSum(new int[] { 6, 9, 7, 10, 14, 16 },21);
            Assert.AreEqual (ret, true, "values are not equal");
            Console.WriteLine ("----------SumOf2 done-------");
        }
    }
}
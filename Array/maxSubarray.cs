using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgCSharp.Array {

    /*
    Find the contiguous subarray within an array (containing at least one number) which has the largest sum.
    For example, given the array [-2,1,-3,4,-1,2,1,-5,4],
    the contiguous subarray [4,-1,2,1] has the largest sum = 6.
     */

    public class MaxSubarray {

        public MaxSubarray () { }

        public int Calculate (int[] arr) {

            int maxSoFar = arr[0];
            int maxTemp = arr[0];
            for (int i = 0; i < arr.Length; i++) {
                maxTemp = Math.Max(maxTemp+arr[i],arr[i]);
                maxSoFar = Math.Max(maxSoFar,maxTemp);    
            }

            return maxSoFar;
        }
    }

      [TestClass]
    public class MaxSubarrayTest {

        [TestMethod]
        public void TestMaxSubarray () {

            var t = new MaxSubarray ();
            var ret = t.Calculate (new int[] {-2, 1, -3, 4, -1, 2, 1, -5, 4 });
            Assert.AreEqual (ret, 6, "values are not equal");
            Console.WriteLine ("----------SubarrayTest done-------");
        }
    }
}
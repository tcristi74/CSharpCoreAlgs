using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgCSharp.Triangle {

    /*
    Given an unsorted array of positive integers. 
    Find the number of triangles that can be formed with three different array elements as three sides of triangles. 
    For a triangle to be possible from 3 values, the sum of any two values (or sides) must be greater than the third value (or third side).
    For example, if the input array is {4, 6, 3, 7}, the output should be 3. 
    There are three triangles possible {3, 4, 6}, {4, 6, 7} and {3, 6, 7}. Note that {3, 4, 7} is not a possible triangle.
    As another example, consider the array {10, 21, 22, 100, 101, 200, 300}. 
    There can be 6 possible triangles: {10, 21, 22}, {21, 100, 101}, {22, 100, 101}, {10, 100, 101}, {100, 101, 200} and {101, 200, 300}
     */

    public class MaxTriangles {

        private readonly List<int> _list;
        private readonly List<string> _combinations;

        public MaxTriangles (int[] arr) {

            _list = arr.OrderBy (p => p).ToList ();
            _combinations = new List<string> ();
        }

        public int getMaxTriangles (bool saveCombinations = false) {
            int maxComb = 0;
            for (int i = 0, j = 1; j < _list.Count; i++, j++) {
                var t1 = _list[i] + _list[j];
                // find the rightmost acceptable value
                var k = findRightMostIndex (t1);
                if (k > j) {
                    //we got k-j values 
                    maxComb += k - j;
                }
            }
            return maxComb;
        }

        private int findRightMostIndex (int val) {
            for (int i = 0; i < _list.Count; i++) {
                if (val <= _list[i]) {
                    return i - 1;
                }
            }
            return _list.Count - 1;
        }

    }
   // [TestClass]
    public class maxtriangles {

        [TestMethod]
        public void TestMaxTriangles () {
            MaxTriangles t = new MaxTriangles (new int[] { 6, 9, 7, 10, 14, 16 });
            var ret = t.getMaxTriangles ();;
            Assert.AreEqual (ret, 7, "values are not equal");
            Console.WriteLine ("----------Max triangles reverse done-------");
        }
    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgCSharp.Power {

    /*
    Implement pow (x, n).
     */

    public class ImplementSqrt {

        public ImplementSqrt () { }

        public int Sqrt (int n) {
            if (n == 0) return 0;
            if (n == 1) return 1;
            //define 2 numbers a and b 
            var a = 1;
            var b = n;
            while (Math.Abs (a - b) > 1) {
                a = (a+b)/2;
                b  = n/a;
                Console.WriteLine("a={0}  ;  b={1}",a,b);
            }
            return a;
        }
    }

    [TestClass]
    public class SqrtTest {

        [TestMethod]
        public void TestSqrt () {
            ImplementSqrt t = new ImplementSqrt ();
            var ret = t.Sqrt (800);
            Assert.AreEqual (ret, 81, "values are not equal");
            Console.WriteLine ("----------Max triangles reverse done-------");
            char a = '4';
   
        }
    }
}
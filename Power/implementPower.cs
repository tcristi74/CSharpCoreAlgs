using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgCSharp.Power {

    /*
    Implement pow(x, n).
     */

    public class ImplementPowxn {

        public ImplementPowxn () {
        }

        public int pow ( int x, int n) {
            if (n==0) return 1;
            if (n==1) return x;
            if (n<0) {
                n=-n;
                x=1/x;
            }

            return n%2==0 ? pow(x*x,n/2) : x *  pow(x*x,n/2);
        }

    }

  //  [TestClass]
    public class ImplementPowxnTest {

        [TestMethod]
        public void TestImplementPowxn () {
            ImplementPowxn t = new ImplementPowxn();
            var ret = t.pow(3,4);
            Assert.AreEqual (ret, 81, "values are not equal");
            Console.WriteLine ("----------Max triangles reverse done-------");
        }
    }
}
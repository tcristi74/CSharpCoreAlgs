using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgCSharp.Array {

    /*
        We need to have two methods, Store and 
     */

    public class TwoSum {

//        private Dictionary<int, int> dic = new Dictionary<int, int> ();
//        private int idx = 0;

        private List<int> list = new  List<int>();  

        public void Store (int n) {
           // dic.Add (idx++, n);
           list.Add(n);
        }

        public bool GetSum(int sumVal){

            Dictionary<int, List<int>> tdic = new Dictionary<int, List<int>> ();

            for(int i=0;i<list.Count;i++)
            {
                var rest  = sumVal-list[i];
                if (!tdic.ContainsKey(rest))
                {
                    tdic.Add(rest,new List<int>() {i});  
                }
                else
                {
                    tdic[rest].Add(i);
                }               
            }              

            for(int i=0;i<list.Count;i++)
            {
                var rest  = sumVal-list[i];
                if (tdic.ContainsKey(rest) && 
                ( !tdic[rest].Contains(i) ||  tdic[rest].Count!=1 )  ){
                    return true;
                }
            }

            return false;

        }
    }


    [TestClass]
    public class TwoSumTest{

        [TestMethod]
        public void TestTwoSum(){

            TwoSum ts = new  TwoSum();
            ts.Store(1);
            ts.Store(2);
            ts.Store(5);
            ts.Store(6);

            bool ret= ts.GetSum(5);
            Assert.AreEqual (ret, true, "values are not equal");
            Console.WriteLine ("----------TwoSum done-------");

        }
    }
}
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgCSharp.MergeSort
{
    
    public class MergeSort
    {
        public MergeSort()
        {
            Console.WriteLine("mergeSort constructor");
        }
          public int DoMergeSort()
        {
            Console.WriteLine("do merge sort");
            return 100;
        }
    }


   // [TestClass]
    public class MergeSortTest
    {

        [TestMethod]
        public void TestMergeSort()
        {
              MergeSort ms =  new MergeSort();
              var res = ms.DoMergeSort();  

              Assert.AreEqual(res,100,"values are not equal");

  Console.WriteLine("----------merge sort done-------");
        }
    }
}
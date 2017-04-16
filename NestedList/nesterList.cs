using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AlgCSharp.NestedList
{
    
    public interface INested
    {
        bool IsNested();

        bool IsNumber();

        bool IsListOfNumbers();

        int GetValue(out int level);
    }

    public class Nlist : INested
    {
        private  Nlist _nestedList;
        private  List<int> _list;

        private int? _val;

        public Nlist(Nlist nlist)
        {
              _nestedList = nlist; 
        }

        public Nlist(List<int> list)
        {
              _list = list;
        }
        public Nlist(int val)
        {
              _val = val;
        }
        public  bool IsNested()
        {
              return _nestedList!=null;  
        }

        public bool IsNumber()
        {
              return _val !=null;  
        }

        public bool IsListOfNumbers()
        {
                return _list !=null;
        }

        public int GetValue(out int level)
        {
            int sum1 = 0;
            if (IsNumber())
            {
                level=1;
                return (int)_val;
            }
            else if (IsListOfNumbers())
            {
                level = 2;
                for (var i = 0; i<_list.Count;i++)
                {
                      sum1+=_list[i];  
                }
                return sum1;
            }
            else 
            {
               sum1= _nestedList.GetValue(out level);
               level+=2;
               return sum1;
            }
        }
        
    }

    public class NestedList :List<Nlist>
    {
        public NestedList()
        {
            Console.WriteLine("NestedList constructor");
        }
          public int GetFinalValue()
        {
            int sumFinal=0;
            for(int i=0;i<this.Count;i++)
            {
                int level;
               var val =this[i].GetValue(out  level);   
               sumFinal+=val*level;
            }
            return sumFinal;
        }
    }


    [TestClass]
    public class NestedListTest
    {

        [TestMethod]
        public void TestNestedList()
        {
              NestedList nlist = new NestedList();
              nlist.Add(new Nlist(new List<int>() {1,1}));
              nlist.Add(new Nlist(2));
              nlist.Add(new Nlist(new List<int>() {1,1}));

              int res1  = nlist.GetFinalValue();

              Console.WriteLine("res1 ={0}",res1)  ;              

              nlist.Add(new Nlist(new List<int>() {1,3}));

              var res2  = nlist.GetFinalValue();
              
              Console.WriteLine("res2 ={0}",res2)  ;

              var nlist2   =new Nlist(new List<int>() {1,1});
              nlist.Add(new Nlist( nlist2));

              var res3  = nlist.GetFinalValue();

              Console.WriteLine("res3 ={0}",res3)  ;


              Assert.AreEqual(res1+res2,28,"values are not equal");
        }

        [TestMethod]
          public void TestNestedList2()
        {
              NestedList nlist = new NestedList();
              nlist.Add(new Nlist(1));
        

              var res1  = nlist.GetFinalValue();
              Console.WriteLine("res1 ={0}",res1)  ;              

              nlist.Add(new Nlist(new List<int>() {4}));
              var res2  = nlist.GetFinalValue();
              Console.WriteLine("res2 ={0}",res2)  ;

              var nlist2   =new Nlist(6);
              nlist.Add(new Nlist( nlist2));

              var res3  = nlist.GetFinalValue();

              Console.WriteLine("res3 ={0}",res3)  ;


              Assert.AreEqual(res3,27,"values are not equal");
        }
    }
}
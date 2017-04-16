using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
namespace AlgCSharp.Stack
{

	public class StackFromQueue
	{
		private Queue<int> _q1;
		private Queue<int> _q2;
		
		public StackFromQueue() {
			_q1 = new Queue<int>();
			_q2 = new Queue<int>();
				
		}
	
		public void Push(int i) {
			_q1.Enqueue(i);
			
		}
	
		public int Pop()
		{
			int lastval=0; 
			while (_q1.Count>0)
			{
				lastval = _q1.Dequeue();	
				if (_q1.Count>0)
				{
					_q2.Enqueue(lastval);
				}
			}

			// put back into queue
			while (_q2.Count>0)
			{	
				_q1.Enqueue(_q2.Dequeue());	
			}
			return lastval;
		}

	}


//	[TestClass]
	public class StackFromQueueTest
	{
		[TestMethod]
		public void TestStackFromQueue()
		{
			StackFromQueue sq = new StackFromQueue() 	;

			int[] arr = new int[7] {4,6,3,4,9,8,2}	;

			Stack<int> gstack = new Stack<int>();		

			Console.WriteLine("StackFromQueue",arr);

			for (int i = 0;i<arr.Length;i++)	
			{
				sq.Push(arr[i]);
				gstack.Push(arr[i]);
			}


			for (int i = 0;i<arr.Length;i++)	
			{
				int vGen = gstack.Pop();
				int v2 = sq.Pop();
				Console.WriteLine("vgen: " +vGen.ToString() + "   v2="+v2.ToString());
				Assert.AreEqual(vGen,v2,"values are not equal");
			}

			  Console.WriteLine("----------StackUsing2queuss sort done-------");

		}
	}
}

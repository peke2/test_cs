using System;
using System.Collections.Generic;


class TestArray
{
	class Test
	{
		int[] nums = {1, 2, 3, 4, 5};

		//	operator [] は使えないが、インデクサーとして定義可能
		public int this[int index]
		{
			get{return nums[index];}
			//set{nums[index]=value;}
		}
		
		public int Length
		{
			get{return nums.Length;}
		}
	}


	static void Main()
	{
		Test test = new Test();
	
		for(int i=0; i<test.Length; i++)
		{
			Console.WriteLine("{0}", test[i]);
		}
	}
}

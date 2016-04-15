//	リストから探す

using System;
using System.Collections;
using System.Collections.Generic;



class ListFindTest
{
	struct PARAM
	{
		public string		name;
		public int			val;
		public List<int>	list;

		public PARAM(string name, int val)
		{
			this.name = name;
			this.val = val;
			this.list = new List<int>();
			this.list.Add(3);
			this.list.Add(5);
		}
	}


	public void findFromInteger()
	{
		List<int> list = new List<int>();

		list.Add(1);
		list.Add(3);
		list.Add(7);
		list.Add(11);
		list.Add(19);
		list.Add(31);

		int	val;

		Console.WriteLine("---- Find [7] ----");
		val = list.Find(n=> n == 7);
		Console.WriteLine("result={0}", val);

		//	見つからない場合は、型<T>の規定値が返る
		//	恐らく 0 が返る
		Console.WriteLine("---- Find [5] ----");
		val = list.Find(n=> n == 5);
		Console.WriteLine("result={0}", val);
	}


	public void findFromStruct()
	{
		List<PARAM> list = new List<PARAM>();

		list.Add(new PARAM("abcde", 999));
		list.Add(new PARAM("hello", 12));
		list.Add(new PARAM("www", 23));

		PARAM	p;

		Console.WriteLine("---- Find [hello] ----");
		p = list.Find(param=> param.name == "hello");
		Console.WriteLine("result={0}->{1}", p.name, p.val);
		Console.WriteLine("list count={0}", p.list.Count);

		//	見つからない場合は、型<T>の規定値が返る
		//	恐らく
			//	PARAM.name = ""
			//	PARAM.val  = 0
			//	PARAM.list = null
		Console.WriteLine("---- Find [Bad] ----");
		p = list.Find(param=> param.name == "Bad");
		Console.WriteLine("NULL?<{0}>", p);
		Console.WriteLine("result={0}->{1}", p.name, p.val);
		//Console.WriteLine("list count={0}", p.list.Count);	//	null参照で例外発生
	}


	static void Main()
	{
		ListFindTest	test = new ListFindTest();
		test.findFromInteger();
		test.findFromStruct();
	}
}

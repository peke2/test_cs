using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;	//	既存の型にメソッドを追加 → Distinct() が使えるようになる


class TestLinq
{
	static void Main()
	{
		List<int> list = new List<int>{4,1,7,3,11,2,4,6,3};

		//	元の内容
		foreach(int n in list)
		{
			Console.Write("{0} ", n);
		}

		Console.WriteLine("");

		//	重複要素削除後
		IEnumerable dl = list.Distinct();
		foreach(int n in dl)
		{
			Console.Write("{0} ", n);
		}
	}
}

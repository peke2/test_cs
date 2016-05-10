using System;
using System.Collections.Generic;

class Merge
{
	static void Main()
	{
		List<int>	la = new List<int>{1,2,3};		//	A
		List<int>	lb = new List<int>{9,11,13};	//	B

		//	List::AddRange() がリストの単純な結合であることを確認する
		//	リストを結合してBの後ろにAがそのまま並んでいることを確認
		//	ソートなどはされていない状態
		lb.AddRange(la);
		foreach(int val in lb)
		{
			Console.WriteLine(val);
			//	結果(予想通り)
			//9
			//11
			//13
			//1
			//2
			//3
		}
	}
}

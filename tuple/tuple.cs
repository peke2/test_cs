using System;
using System.Collections.Generic;

//	Tupleの確認
//	ハッシュや構造体に替わって手軽に使えるテーブルになる？

class T
{
	static void Main()
	{
		//Tuple<string, int> t = Tuple.Create("Hello", 17);
		var t = Tuple.Create("Hello", 17);		//	「var」を使用すると型を意識しなくて良い
												//	データを変えた時に宣言も変更しないといけないのでこっちの方が使いやすい？
		//	各要素へのアクセス
		Console.WriteLine(t.Item1);
		Console.WriteLine(t.Item2);

		List<Tuple<string, int>>	list = new List<Tuple<string, int>>();
		list.Add(Tuple.Create("abc", 123));
		list.Add(Tuple.Create("def", 456));
		list.Add(Tuple.Create("ghi", 789));

		foreach(var n in list)
		{
			Console.WriteLine("item1={0}, item2={1}", n.Item1, n.Item2);
		}
		//	要素が2つならば用途にもよるがハッシュで十分と思われる
	}
}

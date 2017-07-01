//	リストのソート

using System;
using System.Collections;
using System.Collections.Generic;


class Param
{
	public int value;
	public string name;

	public Param(int value, string name)
	{
		this.value = value;
		this.name = name;
	}
}


class ListSort
{
	static void Main()
	{
		ListSort	ls = new ListSort();

		Console.WriteLine("---- Descending Sort ----");
		ls.sortDescending();

		Console.WriteLine("");

		Console.WriteLine("---- Ascending Sort ----");
		ls.sortAscending();
	}


	public void sortAscending()
	{
		List<int> list = new List<int>();

		list.Add(4);
		list.Add(76);
		list.Add(21);
		list.Add(9);
		list.Add(1);
		list.Add(7);

		Console.WriteLine("---- Before Sort ----");
		foreach(int p in list){Console.Write("{0} ", p);}

		Console.WriteLine("");

		//	昇順
		list.Sort((a,b)=> a-b);		//	[マイナス] : a<b
									//	[0]        : a==b
									//	[プラス]   : a>b
									//	この状態を返せば昇順でソートされる
									//	数値をキーにして昇順でソートをしたければ
									//	a - b を比較関数にセットする

		Console.WriteLine("---- After Sort ----");
		foreach(int p in list){Console.Write("{0} ", p);}

	}


	public void sortDescending()
	{
		List<Param> list = new List<Param>();

		list.Add(new Param(-43, "test"));
		list.Add(new Param(0, "hello"));
		list.Add(new Param(0, "Good"));
		list.Add(new Param(-1, "aaaaa"));
		list.Add(new Param(11, "score"));
		list.Add(new Param(2, "name"));

		Console.WriteLine("---- Before Sort ----");
		foreach(Param p in list){Console.WriteLine("[{0}]->{1}", p.value, p.name);}

		//	降順のソート
		//	結果がマイナスならばリストの前に、プラスならリストの後ろにくる
		list.Sort((a,b)=> b.value - a.value);

		Console.WriteLine("---- After Sort ----");
		foreach(Param p in list){Console.WriteLine("[{0}]->{1}", p.value, p.name);}

	}
}

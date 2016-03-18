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
		List<Param> list = new List<Param>();

		list.Add(new Param(-43, "test"));
		list.Add(new Param(0, "hello"));
		list.Add(new Param(0, "Good"));
		list.Add(new Param(-1, "aaaaa"));
		list.Add(new Param(11, "score"));
		list.Add(new Param(2, "name"));

		Console.WriteLine("---- Before Sort ----");
		foreach(Param p in list){Console.WriteLine("[{0}]->{1}", p.value, p.name);}

		list.Sort((a,b)=> b.value - a.value);

		Console.WriteLine("---- After Sort ----");
		foreach(Param p in list){Console.WriteLine("[{0}]->{1}", p.value, p.name);}

	//	Console.WriteLine("result={0}", is_equal);
	}
}

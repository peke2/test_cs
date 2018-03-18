using System;
using System.Collections.Generic;


class GetValue
{
	static void Main()
	{
		Dictionary<int, string> dict = new Dictionary<int, string>();

		dict.Add(1, "Hello");
		dict.Add(3, "Bye");

		int key = 1;
		Console.WriteLine("key{0}={1}", key,  dict[key]);

		//	辞書にキーが存在しない場合の例外の動作を確認する
		key = 2;
		try
		{
			Console.WriteLine("key{0}={1}", key,  dict[key]);
		}
		catch(KeyNotFoundException e)	//	明示的にキーの有無を判断する場合
		//catch(Exception e)	//	一応、これでも検出は可能だけど、他の例外の可能性もある
		{
			Console.WriteLine(e.Message);
			Console.WriteLine("key{0}は存在しません", key);
		}
	}
}

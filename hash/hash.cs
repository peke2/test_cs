using System;
using System.Collections;

class HashTest
{
	static void Main()
	{
		Hashtable table = new Hashtable();

		table.Add( 2, "weapon");
		table.Add( 1, "armor");
		table.Add(13, "item");

		int		key;
		key = 2;
		outputValue(table, key);	//	キーに対する値を出力

		key = 5;
		outputValue(table, key);	//	キーに該当する値が無ければ「null」を返す
		table[key] = "Hello!";		//	キーに該当する値をセット
		outputValue(table, key);	//	もう一度出力をすると内容が書き換えられたことが分かる
	}

	static void outputValue(Hashtable table, int key)
	{
		if( null == table[key] )
		{
			Console.WriteLine("key[{0}]=null", key);
		}
		else
		{
			Console.WriteLine("key[{0}]={1}", key, table[key]);
		}
	}
}

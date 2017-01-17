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

		valueType();
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

	//	ハッシュが保持する値の型の確認
	static void valueType()
	{
		Hashtable table = new Hashtable();

		table.Add("weapon", 5);
		table.Add("armor" , 3);
		table.Add("item"  , "bomb");

		System.Type	type;
		type = table["armor"].GetType();
		Console.WriteLine( type );		//	System.Int32

		type = table["item"].GetType();
		Console.WriteLine( type );		//	System.String

		//	ハッシュテーブルに保持されている数値を関数の呼び出しで使えるか？
		int		total;
		//total = add(table["armor"], table["weapon"]);		//	引数にobject(System.Int32)は渡せないのでコンパイルエラー
		total = add((int)table["armor"], (int)table["weapon"]);	//	キャストすればOK
		Console.WriteLine("{0}+{1}={2}", table["armor"], table["weapon"], total);
	}

	static int add(int a, int b)	//	引数は「int」
	{
		return	a+b;
	}
}

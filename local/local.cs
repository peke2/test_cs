//	ローカル変数の定義で疑問に思ったことを確認

using System;
using System.Collections.Generic;

class Local
{
	static void Main()
	{
		int		value = 0;

		//	基本的にC#では、同じまたは親スコープ内で使用されている変数は再宣言できない

		//	CやC++で出来たこの宣言方法は使えない
		//	コンパイル時にエラーが出る
		/*
		{
			int	value = 123;
			Console.WriteLine("value={0}", value);
		}*/

		//	既に定義されている旨のエラーが出る
		//int value = 123;

		//	これもコンパイルエラー
		//	スコープ内で使われている変数を上書きしてしまう心配なく使える！！
		/*
		for(int value=0; value<1; value++)
		{
		}
		*/

		//	これもコンパイルエラー
		//	前後の処理で使用している変数を上書きする心配が無くなる
		/*
		List<int>	l = new List<int>();
		List<int>	list = new List<int>();
		foreach(int li in l)
		{
		}
		foreach(int l in list)		//	ここでコンパイルエラー
		{
		}
		*/

		//	これはOK
		//	同じスコープ内じゃないし、親のスコープで宣言されていない
		for(int i=0; i<3; i++)
		{
		}
		for(int i=3; i<6; i++)
		{
		}

		{
			int	a = 0;
			Console.WriteLine("{0}",a);
		}
		{
			int	a = 4;
			Console.WriteLine("{0}",a);
		}


		//	結論
		//	必要なローカル変数を宣言してエラーが出なければ、それは使われていないことを意味するので
		//	気にすること無く使って良い
	}
}

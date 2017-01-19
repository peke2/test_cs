using System;


class TestString
{
	static void Main()
	{
		split("abc_def_ghi");
		Console.WriteLine("--------");
		split("");	//	要素1つ、長さ0の文字列
		Console.WriteLine("--------");
		split("abcdef");
		Console.WriteLine("--------");
		split("123_4_56_789_");
		Console.WriteLine("--------");
		split("あい__ueo_かきく");	
		Console.WriteLine("--------");

		//	出力結果
	/*
		3
		[abc] 文字数=3
		[def] 文字数=3
		[ghi] 文字数=3
		--------
		1
		[] 文字数=0
		--------
		1
		[abcdef] 文字数=6
		--------
		5
		[123] 文字数=3
		[4] 文字数=1
		[56] 文字数=2
		[789] 文字数=3
		[] 文字数=0
		--------
		4
		[あい] 文字数=2
		[] 文字数=0
		[ueo] 文字数=3
		[かきく] 文字数=3
		--------
	*/

		//	空文字列を除く
		split("あい__ueo_かきく", true);
		Console.WriteLine("--------");
	/*
		3
		[あい] 文字数=2
		[ueo] 文字数=3
		[かきく] 文字数=3
		--------
	*/
	}

	//	文字列解析用の確認
	static void split(string str, bool removes_empty=false)
	{
		string[]	strTbl;

		if( true == removes_empty )
		{
		//	strTbl = str.Split('_', StringSplitOptions.RemoveEmptyEntries);	//	この書き方はダメ
			Char[]	delims = {'_'};
			strTbl = str.Split(delims, StringSplitOptions.RemoveEmptyEntries);
		}
		else
		{
			strTbl = str.Split('_');	//	引数がCharだとコンパイラが1要素の配列として解釈してくれるらしい？
										//	https://msdn.microsoft.com/ja-jp/library/b873y76a(v=vs.110).aspx
		}

		Console.WriteLine(strTbl.Length);
		foreach(String s in strTbl)
		{
			Console.WriteLine("[{0}] 文字数={1}", s, s.Length);
		}
	}
}

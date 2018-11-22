using System;
using System.Collections.Generic;

//	URIの結合動作の確認

class T
{
	static void Main()
	{
		//	基本的に、URLの階層構造をベースにURIが生成される
		var baseUrl = new Uri("http://127.0.0.1");
		var combined = new Uri(baseUrl, "abcd/efg");
		Console.WriteLine(combined.AbsoluteUri);	//	http://127.0.0.1/abcd/efg

		baseUrl = new Uri("http://127.0.0.1/qw");	//	「qw」はディレクトリとして扱われていない
		combined = new Uri(baseUrl, "abcd/efg");
		Console.WriteLine(combined.AbsoluteUri);	//	http://127.0.0.1/abcd/efg	↑と結果が変わらない

		baseUrl = new Uri("http://127.0.0.1/zz/");
		combined = new Uri(baseUrl, "abcd/efg");
		Console.WriteLine(combined.AbsoluteUri);	//	http://127.0.0.1/zz/abcd/efg

		baseUrl = new Uri("http://127.0.0.1/zz/");
		combined = new Uri(baseUrl, "/abcd/efg");	//	ルートディレクトリ
		Console.WriteLine(combined.AbsoluteUri);	//	http://127.0.0.1/abcd/efg	↑から「zz」が抜ける
	}
}

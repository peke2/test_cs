using System;

class Nullable
{
	static public void Main()
	{
		float	a = 1.0f;
		float?	b = 2.0f;

		Console.WriteLine("a={0}", a);

		//a = null;		//	NULLが許容されていないので、コンパイルエラー
		b = null;		//	NULL許容型なので、nullの代入が可能

		//	NULL許容型は以下のメソッドを使用可能
		if( b.HasValue )	Console.WriteLine("b={0}", b);
		else				Console.WriteLine("b=NULL");

		//	NULL許容型の数値参照に「Value」を使うと、nullの場合に例外がスローされる
		try
		{
			Console.WriteLine("b={0}", b.Value);
		}
		catch(System.InvalidOperationException e)
		{
			Console.WriteLine(e.Message);
		}
	}

}

using System;


class Test
{
	//	yieldを使った反復子の実装
		//	■yield (C#リファレンス)
		//	https://docs.microsoft.com/ja-jp/dotnet/csharp/language-reference/keywords/yield
	class Iteration
	{
		public System.Collections.Generic.IEnumerable<int> getParam()
		{
			for(int i=0; i<5; i++)
			{
				yield return i;
			}
		}
	}


	static void Main()
	{
		Iteration it = new Iteration();

		foreach(int i in it.getParam())
		{
			Console.WriteLine("{0}", i);
		}
	}
}

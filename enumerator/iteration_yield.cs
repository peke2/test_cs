using System;


class Test
{
	//	yield���g���������q�̎���
		//	��yield (C#���t�@�����X)
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

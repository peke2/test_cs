using System;

class TestReplace
{
	static void Main()
	{
		//	一致しないと置き換えられないのか？
		string source = "あいうえお";
		string dest = source.Replace("いえ", "");

		//	[あいうえお]->[あいうえお]
		Console.WriteLine("[{0}]->[{1}]", source, dest);


		source = "あいうえお";
		dest = source.Replace("いう", "");

		//	一致しないと置き換えられない
		//	[あいうえお]->[あえお]
		Console.WriteLine("[{0}]->[{1}]", source, dest);

		//	おまけ
		source = "Hi_-10db";
		dest = source.Replace("-", "");
		//	[Hi_-10db]->[Hi_10db]
		Console.WriteLine("[{0}]->[{1}]", source, dest);

	}
}


using System;

class TestSplit
{
	static void Main()
	{
		//	元文字列
		string path = "abc/de/fghi/jklmnop";
		//	分割用文字
		char[] separator = new char[]{'/'};

		string[] splited = path.Split(separator);

		Console.WriteLine("元文字列[{0}]", path);
		foreach(string s in splited)
		{
			Console.WriteLine(s);
		}
	}
}


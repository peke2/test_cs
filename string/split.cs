using System;

class TestSplit
{
	static void Main()
	{
		//	Œ³•¶Žš—ñ
		string path = "abc/de/fghi/jklmnop";
		//	•ªŠ„—p•¶Žš
		char[] separator = new char[]{'/'};

		string[] splited = path.Split(separator);

		Console.WriteLine("Œ³•¶Žš—ñ[{0}]", path);
		foreach(string s in splited)
		{
			Console.WriteLine(s);
		}
	}
}


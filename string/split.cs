using System;

class TestSplit
{
	static void Main()
	{
		//	��������
		string path = "abc/de/fghi/jklmnop";
		//	�����p����
		char[] separator = new char[]{'/'};

		string[] splited = path.Split(separator);

		Console.WriteLine("��������[{0}]", path);
		foreach(string s in splited)
		{
			Console.WriteLine(s);
		}
	}
}


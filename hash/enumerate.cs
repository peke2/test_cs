//	ハッシュの列挙

using System;
using System.Collections;

class HashTest
{
	static void Main()
	{
		Hashtable table = new Hashtable();

		table.Add("a", 1);
		table.Add("b", 23);
		table.Add("c", 17);
		table.Add("d", 31);

		foreach(DictionaryEntry d in table)
		{
			Console.WriteLine("key={0}, value={1}", d.Key, d.Value);
			/*
			key=d, value=31
			key=b, value=23
			key=c, value=17
			key=a, value=1

			ハッシュなので、順番に関してはkeyでソートされたりしない
			*/
		}
	}
}

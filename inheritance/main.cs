using System;

//	継承確認用

class Test
{
	public static void Main(string[] args)
	{
	/*
		for(int i=0; i<args.Length; i++)	Console.WriteLine(args[i]);
		Console.WriteLine("--------");
		foreach(string arg in args)	Console.WriteLine(arg);
	*/
		Base b = new Base();
		Console.WriteLine("Base add(1,3)={0}", b.add(1, 3));

		Base s = new Sub();
		Console.WriteLine("Sub add(1,3)={0}", s.add(1, 3));

	}

}

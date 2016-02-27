using System;

//	継承確認用(サブ)

public class Sub : Base
{
	public Sub()
	{
		Console.WriteLine("Sub ctor is called");
	}

	public override int add(int a, int b)
	{
		return a + b;
	}

}

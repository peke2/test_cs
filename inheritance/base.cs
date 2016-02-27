using System;

//	継承確認用(ベース)

public class Base
{
	public Base()
	{
		Console.WriteLine("Base ctor is called");
	}

	public virtual int add(int a, int b)
	{
		return a * b;
	}

}

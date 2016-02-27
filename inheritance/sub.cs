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
	//	return base.add(a,b);	//	ベースクラスへのアクセスは「super」じゃないので注意
		return a + b;
	}

}

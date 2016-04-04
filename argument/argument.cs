//	引数で渡される参照の挙動を確認する

using System;

class Param
{
	public	int		value;
	public	string	name;

	public Param(int v, string s)
	{
		value = v;
		name = s;
	}

	public void output()
	{
		Console.WriteLine("v={0}/name={1}", value, name);
	}
}


class Test
{
	static void Main()
	{
		Test	test = new Test();

		Param	param = new Param(234, "Hello");

		Console.WriteLine("---- before ----");
		param.output();

		//	内部で参照を保持
		test.keep(param);
		//	保持した参照に対して書き換えを行う
		test.rewrite();

		Console.WriteLine("---- after ----");
		//	元のインスタンスの内容が書き換わっていることを確認
		param.output();

	}

	public Param param;

	public void keep(Param param)
	{
		this.param = param;
	}

	public void rewrite()
	{
		this.param.value = 156;
		this.param.name = "rewrite ok";
	}

}

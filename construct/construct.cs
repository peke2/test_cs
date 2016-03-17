//	インスタンス作成時の動作確認

using System;

class Info
{
	public		int		a;
	public		int		b;
	protected	int		c;
	public		string	greeting;

	public Info()
	{
		a = 13;
		b = 23;
		c = 3;
		greeting = "Good morning";
	}

	public void output()
	{
		Console.WriteLine("a={0}", a);
		Console.WriteLine("b={0}", b);
		Console.WriteLine("c={0}", c);
		Console.WriteLine("greeting={0}", greeting);
	}
}



class Construct
{
	static void Main()
	{
		//	オブジェクト初期化子
		//	https://msdn.microsoft.com/ja-jp/library/bb384062.aspx
		string	greeting = "Hello";
	//	Info	info = new Info(){a=2, b=5, c=11, greeting="Hello"};	//	プロパティ「c」は外部からアクセス不可
		Info	info = new Info(){a=2, b=5, greeting=greeting};

		info.output();
	}

}

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

	//	プロパティ「c」は外部からアクセス不可
	//	Info	info = new Info(){a=2, b=5, c=11, greeting="Hello"};

	//	string	greeting = "Hello";	//メンバーと同じ名前の変数を指定しても参照されない
	//	Info	info = new Info(){a=2, b=5, greeting=greeting};
	//	Info	info = new Info(){a=2, b=5, this.greeting=greeting};	//	「this」は静的プロパティ、静的メソッド、静的フィールド初期化子では使えない

		string	greet_text = "Hello";
		Info	info = new Info(){a=2, b=5, greeting=greet_text};

		info.output();
	}

}

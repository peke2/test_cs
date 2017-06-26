using System;

//	プロパティアクセス

class Test
{
	public Test()
	{
		m_param = 123;
	}

	//	自動でゲッター、セッターを割り当て
	public int value
	{
		//	自動で割り当てる場合は「get」「set」両方の宣言が必要
		get;
		set;
		//private set;	//	自動で割り当てる際に書き込みをされたくなければ「private」で宣言する
	}

	int m_param;
	public int param
	{
		get {return m_param;}
		//	「set」が無いので書き込み不可
	}

	//	外からは書き込みのみ
	int m_serial;
	public int serial
	{
		set {m_serial = value;}
	}

}


class TestMain
{
	static void Main()
	{
		Test	test = new Test();

		Console.WriteLine("before value={0}", test.value);
		test.value = 5;
		Console.WriteLine("after value={0}", test.value);

		Console.WriteLine("before param={0}", test.param);
		//test.param = 17;	//	「set」が無いので書き込みはできない
		//Console.WriteLine("after param={0}", test.param);

		test.serial = 31;
		//Console.WriteLine("serial={0}", test.serial);	//	「get」が無いので外部からは参照できない
	}
}

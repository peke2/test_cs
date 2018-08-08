using System;

class Test
{
	#if false
	//	こっちはC#6.0から使用可能
	public int Value {get; set;};
	public int Num {get; private set;} = getDefaultNum();
	#else
	private int _value;
	public int Value
	{
		get {return _value;}
		set {_value = value;}
	}

	private int _num;
	public int Num {
		get {return _num;}
		private set {_num = value;}
	}
	#endif


	private string _word;
	public string Word
	{
		get{return _word;}
		set{_word = value;}
	}

	public Test()
	{
		Num = getDefaultNum();
	}

	private int getDefaultNum()
	{
		return 987;
	}
}


class Property
{
	static void Main()
	{
		Test test = new Test();

		Console.WriteLine(test.Value);

		Console.WriteLine(test.Num);
		test.Num = 3456;	//	セッターはprivateなので、外からは書き込みできない

		test.Word = "Good Night";
		Console.WriteLine(test.Word);
	}
}

using System;

class Greeting
{
	string word;
	public Greeting(string word)
	{
		this.word = word;
	}

	public void say()
	{
		Console.WriteLine(word);
	}
}

class ArrayTest
{
	static void Main()
	{
		//	配列の初期化はどちらでもOK

	#if	false
		//	配列の作成時に内容を初期化
		Greeting[]	list = new Greeting[4]{
			new Greeting("Hello"),
			new Greeting("Good morning"),
			new Greeting("Good bye"),
			new Greeting("Good night"),
		};
	#else
		//	内容の初期化は後
		Greeting[]	list = new Greeting[4];
		list[0] = new Greeting("Hello");
		list[1] = new Greeting("Good morning");
		list[2] = new Greeting("Good bye");
		list[3] = new Greeting("Good night");
	#endif

		foreach(Greeting gr in list)
		{
			gr.say();
		}

	}
}

//	コンストラクタからコンストラクタを呼び出す

using System;

namespace Test{
	class Greeter
	{
		string word = "...";
		
		//	コンストラクタから他のコンストラクタを呼び出す方法は、C#とJavaで異なる
		public Greeter() : this("Hello")
		{
			//	Javaだと以下の形でいける
			//this("Hello");
		}

		public Greeter(string word)
		{
			this.word = word;
		}

		public void say()
		{
			Console.WriteLine(word);
		}
	}
	
	class Call
	{
		static void Main()
		{
			var gr = new Greeter();
			//var gr = new Greeter("Good bye");
			gr.say();
		}
	}
}

using System;
using System.Linq.Expressions;

//	匿名メソッド

namespace MyTest
{
	class Anonymous
	{
		delegate string SAMPLE();
		delegate int TEST(int a, int b);

		static void call(Predicate<string> word)	//	bool Predicate<in T>(T obj)	戻り値はbool固定
		{
			Console.WriteLine("[{0}]", word("hello").ToString());
			Console.WriteLine("[{0}]", word("bye").ToString());
		}

		delegate string Say();

		static void call2(Say say)
		{
			Console.WriteLine("{0}",say());
		}

		static void Main()
		{
			//	関数を定義せずに使用可能
			Anonymous.call(delegate(string word){return word=="hello";});
			Anonymous.call2(delegate(){return "hello";});
		}
	}
}


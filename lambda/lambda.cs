using System;
using System.Linq.Expressions;

//	ラムダ式を使ってみる

namespace MyTest
{
	class Lambda
	{
		delegate string SAMPLE();
		delegate int TEST(int a, int b);

		static void Main()
		{
			SAMPLE s = () => "Hello";
			Console.WriteLine("result={0}", s());

			int a = 3;
			int b = 7;
			TEST	t = (c, d)=>c+d;
			Console.WriteLine("add{0}+{1}={2}", a, b, t(a,b));

		}
	}
}


using System;
using System.Collections.Generic;

//delegateテスト

namespace TestDelegate
{
	delegate int Calc(int a, int b);

	class Test
	{
		static void Main()
		{
			List<Calc>	list = new List<Calc>();
			list.Add(add);
			list.Add(sub);
			list.Add(mul);

			int a = 5;
			int b = 19;
			foreach(var calc in list)
			{
				int c = calc(a, b);
				Console.WriteLine("{0},{1} => {2}", a, b, c);
			}

		}

		static int add(int a, int b)	{return a+b;}
		static int mul(int a, int b)	{return a*b;}
		static int sub(int a, int b)	{return a-b;}
	}
}

using System;

//	数値の確認

class Num
{
	static void Main()
	{
		Console.WriteLine(int.MaxValue);	//	2147483647
		Console.WriteLine(int.MinValue);	//	-2147483648
		//	↓整数型でこれやるとエラー
	//	Console.WriteLine(Math.Abs(int.MinValue));
	//	Console.WriteLine(Math.Abs(int.MinValue+1));	//	こっちはOK

		//	32bit 整数の最大値を単精度浮動小数型にキャストすると精度が足りない
		float f;
		f = int.MaxValue;
		Console.WriteLine(f);

		//	数値が丸められても同じもので割れば結果は「1」になる
		f = (float)int.MaxValue / int.MaxValue;
		Console.WriteLine(f);

		//	32bit整数の最大値を倍精度小数型へキャストすると精度は十分なのでそのままの数値が出せる
		double d;
		d = int.MaxValue;
		Console.WriteLine(d);

		//	少数以下の扱い
		//	キャストした場合は切り捨てになることを確認
		Console.WriteLine("少数以下の扱い");
		f = 1.6f;
		Console.WriteLine(f);
		int		i;
		i = (int)f;
		Console.WriteLine(i);
	}
}


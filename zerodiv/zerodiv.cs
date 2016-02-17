using System;

class ZeroDiv
{
	static void Main()
	{
		//	整数の場合、0除算は例外発生
	//	float	a = 0;
	//	float	b = 1/a;
		//	浮動小数の場合、0除算の結果は「∞」
		float	a = 0;
		float	b = 1/a;
		Console.WriteLine(b);
	}
}

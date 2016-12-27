using System;

//	演算子の動作確認
//	C言語の場合、gcc、clang、VisualStudio で結果が異なっていた

class IncDec
{
	static void Main()
	{
		int i;
		int a,b,c,d;

		i=0;
		a=++i + ++i;
		i=0;
		b=++i + i++;
		i=0;
		c=i++ + ++i;
		i=0;
		d=i++ + i++;
		i=0;

		Console.WriteLine("{0},{1},{2},{3}",a,b,c,d);	//3,2,2,1
	}
}

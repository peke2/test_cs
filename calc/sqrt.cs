using System;

class Sqrt
{
	static public void Main()
	{
		//	負の数の平方根はいくつになるのか？
		Console.WriteLine(Math.Sqrt(2));		//1.4142135623731
		Console.WriteLine(Math.Sqrt(-2));		//NaN (非数値)
	}
}

//	構造体とクラス

using	System;

class PosClass
{
	public int	x;
	public int	y;

	override public string ToString()
	{
		return "x="+x.ToString()+"/y="+y.ToString();
	}
}

struct PosStruct
{
	public int	x;
	public int	y;

	override public string ToString()
	{
		return "x="+x.ToString()+"/y="+y.ToString();
	}
}

class Test
{
	static void Main()
	{
		changeValue();
	}


	//	数値の変更
	static void changeValue()
	{
		PosClass pc = new PosClass();
		PosStruct ps = new PosStruct();
		pc.x = 1;
		pc.y = 0;
		ps.x = 1;
		ps.y = 0;

		Console.WriteLine("-------- 変更前");
		Console.WriteLine(pc);
		Console.WriteLine(ps);

		change(pc, ps);

		Console.WriteLine("-------- 変更後");
		Console.WriteLine(pc);	//	x=3		参照渡しなので変更は反映される
		Console.WriteLine(ps);	//	x=1		値渡しなので変更は反映されない
	}

	static void change(PosClass pc, PosStruct ps)
	{
		pc.x = 3;
		ps.x = 3;
	}


	//	nullは許容されるのか
	static void nullable()
	{
		PosClass pc = null;
		//PosStruct ps = null;		//	値型なので null をセットできない旨のコンパイルエラー
	}


	//	未割当 → そもそもコンパイルを通らない
	static void unassigned()
	{
	#if false
		PosClass	pc;
		PosStruct	ps;

		Console.WriteLine(pc);
		Console.WriteLine(ps);
	#endif
	}
}

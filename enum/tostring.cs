using System;
using System.Collections.Generic;


class TestTostring
{
	enum Type{
		abc,
		val123456,
		ghi,
	};
	
	static void Main()
	{
		int i = (int)Type.val123456;
		Console.WriteLine("(int)="+i);	//	Cなどのenumと同じで順番に数値が割り振られる
		Console.WriteLine("内容="+Type.val123456);	//	暗黙でToString()が呼ばれる → そのままの定義名が文字列になる！！
	}
}

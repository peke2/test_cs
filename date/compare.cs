using System;
using System.Collections.Generic;


class Compare
{
	static void Main()
	{
		DateTime da = new DateTime(2018,1,1);
		DateTime db = new DateTime(2018,1,1);
		DateTime dc = new DateTime(2018,1,2);
		DateTime dd = new DateTime(2017,12,31);


		//	引数の「,」を条件の記号(==、<、>)に置き換えればそのまま読める
		if( DateTime.Compare(da, db) == 0 )
		{
			Console.WriteLine("等しい");
		}
		else
		{
			Console.WriteLine("等しくない");
		}

		if( DateTime.Compare(da, dc) < 0 )
		{
			Console.WriteLine("大きい");
		}
		else
		{
			Console.WriteLine("大きくない");
		}

		if( DateTime.Compare(da, dd) > 0 )
		{
			Console.WriteLine("小さい");
		}
		else
		{
			Console.WriteLine("小さくない");
		}
	}
}

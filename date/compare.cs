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

		//	タイマー開始時近辺での比較
		DateTime st = new DateTime(1970,1,1);
		Console.WriteLine("da="+da.ToString());
		Console.WriteLine("st="+st.ToString());
		if( DateTime.Compare(da, st) <= 0 )
		{
			Console.WriteLine("da <= st");
		}
		else
		{
			Console.WriteLine("da > st");
		}
		Console.WriteLine("");

		/*
		public static int Compare(
			DateTime t1,
			DateTime t2
		)
		0 より小さい値
		t1 が t2 よりも前の日時です。

		0
		t1 は t2 と同じです。

		0 より大きい値
		t1 が t2 より後の日時です。
		*/

		//	0と比較した場合、引数の「,」を条件の記号(==、<、>)に置き換えればそのまま読める
		Console.WriteLine("da="+da.ToString());
		Console.WriteLine("db="+db.ToString());
		if( DateTime.Compare(da, db) == 0 )
		{
			Console.WriteLine("da == db");
		}
		else
		{
			Console.WriteLine("da != db");
		}
		Console.WriteLine("");

		Console.WriteLine("da="+da.ToString());
		Console.WriteLine("dc="+dc.ToString());
		if( DateTime.Compare(da, dc) < 0 )
		{
			Console.WriteLine("da < dc");
		}
		else
		{
			Console.WriteLine("da >= dc");
		}
		Console.WriteLine("");

		Console.WriteLine("da="+da.ToString());
		Console.WriteLine("dd="+dd.ToString());
		if( DateTime.Compare(da, dd) > 0 )
		{
			Console.WriteLine("da > dd");
		}
		else
		{
			Console.WriteLine("da <= dd");
		}
	}
}

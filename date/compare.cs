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

		//	�^�C�}�[�J�n���ߕӂł̔�r
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
		0 ��菬�����l
		t1 �� t2 �����O�̓����ł��B

		0
		t1 �� t2 �Ɠ����ł��B

		0 ���傫���l
		t1 �� t2 ����̓����ł��B
		*/

		//	0�Ɣ�r�����ꍇ�A�����́u,�v�������̋L��(==�A<�A>)�ɒu��������΂��̂܂ܓǂ߂�
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

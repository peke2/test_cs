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


		//	�����́u,�v�������̋L��(==�A<�A>)�ɒu��������΂��̂܂ܓǂ߂�
		if( DateTime.Compare(da, db) == 0 )
		{
			Console.WriteLine("������");
		}
		else
		{
			Console.WriteLine("�������Ȃ�");
		}

		if( DateTime.Compare(da, dc) < 0 )
		{
			Console.WriteLine("�傫��");
		}
		else
		{
			Console.WriteLine("�傫���Ȃ�");
		}

		if( DateTime.Compare(da, dd) > 0 )
		{
			Console.WriteLine("������");
		}
		else
		{
			Console.WriteLine("�������Ȃ�");
		}
	}
}

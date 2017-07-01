using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;	//	�����̌^�Ƀ��\�b�h��ǉ� �� Distinct() ���g����悤�ɂȂ�


class TestLinq
{
	static void Main()
	{
		List<int> list = new List<int>{4,1,7,3,11,2,4,6,3};

		//	���̓��e
		foreach(int n in list)
		{
			Console.Write("{0} ", n);
		}

		Console.WriteLine("");

		//	�d���v�f�폜��
		IEnumerable dl = list.Distinct();
		foreach(int n in dl)
		{
			Console.Write("{0} ", n);
		}
	}
}

using System;
using System.Collections.Generic;


class GetValue
{
	static void Main()
	{
		Dictionary<int, string> dict = new Dictionary<int, string>();

		dict.Add(1, "Hello");
		dict.Add(3, "Bye");

		int key = 1;
		Console.WriteLine("key{0}={1}", key,  dict[key]);

		//	�����ɃL�[�����݂��Ȃ��ꍇ�̗�O�̓�����m�F����
		key = 2;
		try
		{
			Console.WriteLine("key{0}={1}", key,  dict[key]);
		}
		catch(KeyNotFoundException e)	//	�����I�ɃL�[�̗L���𔻒f����ꍇ
		//catch(Exception e)	//	�ꉞ�A����ł����o�͉\�����ǁA���̗�O�̉\��������
		{
			Console.WriteLine(e.Message);
			Console.WriteLine("key{0}�͑��݂��܂���", key);
		}
	}
}

using System;
using System.Collections.Generic;


class TestArray
{
	class Test
	{
		public IEnumerator<int> getParam()
		{
			for(int i=0; i<5; i++)
			{
				//�����ɏ����������΃X���b�h�̂悤�ɓ����C�x���g������

				yield return i;
			}
			Console.WriteLine("����");
		}
	}



	static void Main()
	{
		Test test = new Test();
	
		IEnumerator<int> em;
		em = test.getParam();

		bool isEnd = false;
		while(false == isEnd)
		{
			//	�����̃C���f�b�N�X�́u-1�v����n�߂錈�܂肪����̂ŁA�ŏ�����uMoveNext�v���Ăяo��
			if( em.MoveNext() == true )
			{
				Console.WriteLine(em.Current);
			}
			else
			{
				isEnd = true;
			}
		}
	}
}

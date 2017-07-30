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
				//ここに処理を書けばスレッドのように動くイベントが作れる

				yield return i;
			}
			Console.WriteLine("完了");
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
			//	内部のインデックスは「-1」から始める決まりがあるので、最初から「MoveNext」を呼び出す
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

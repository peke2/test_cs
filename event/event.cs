using System;
using System.Collections;
using System.Collections.Generic;

namespace Test{
	class Event
	{
		public delegate int CallEvent(int a);

		public event CallEvent events;

		public void update()
		{
			if( null != events )
			{
				events(123);
			}
		}

		static void Main()
		{
			Sample sample = new Sample();
			Event ev = new Event();

			Console.WriteLine("-------- 複数回呼び出し");
			//	登録した回数だけ呼ばれる
			ev.events += sample.proc;
			ev.events += sample.proc;

			ev.update();

			Console.WriteLine("-------- 呼び出し1回削除");
			ev.events -= sample.proc;

			ev.update();

			Console.WriteLine("-------- 呼び出しもう1回削除(登録処理無し)");
			ev.events -= sample.proc;

			ev.update();

			Console.WriteLine("-------- 余計に削除しても大丈夫");
			ev.events -= sample.proc;

			ev.update();
		}
	}


	public class Sample
	{
		public int proc(int a)
		{
			Console.WriteLine("{0}", a);
			return 99;
		}
	}
}
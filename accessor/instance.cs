using System;
using System.Collections;
using System.Collections.Generic;

class TestInstance
{
	class Test : IDisposable
	{
		public static Test instance
		{
			//	自動で内容を割り当てる場合は「get」「set」両方を定義する必要あり
			get;
			private set;
		}

		public Test()
		{
			//	通常のシングルトンだと、new する前に存在を確認して無ければ作る
			//	Unityのようにオブジェクトの生成タイミングが不明な場合、
			//	重複するインスタンスを作られた直後に削除することで対応する
			//	http://tsubakit1.hateblo.jp/entry/2015/11/07/024350
			if( null != instance )
			{
				Console.WriteLine("Already exists.");
				this.Dispose();
				return;
			}

			instance = this;
		}

		private string m_greeting;

		public void setGreeting(string greeting)
		{
			m_greeting = greeting;
		}

		public void say()
		{
			Console.WriteLine(m_greeting);
		}

		public void Dispose()
		{
		}
	}

	static void Main()
	{
		//	最初にインスタンスを作成
		Test t = new Test();
		t.setGreeting("Hello");
		t.say();

		//	以降はインスタンスの作成はできない
		Test ta = new Test();

		//	既に存在するインスタンスを参照
		Test tb = Test.instance;
		tb.say();
	}
}

using System;
using System.Collections;
using System.Collections.Generic;

class TestInstance
{
	class Test : IDisposable
	{
		public static Test instance
		{
			//	�����œ��e�����蓖�Ă�ꍇ�́uget�v�uset�v�������`����K�v����
			get;
			private set;
		}

		public Test()
		{
			//	�ʏ�̃V���O���g�����ƁAnew ����O�ɑ��݂��m�F���Ė�����΍��
			//	Unity�̂悤�ɃI�u�W�F�N�g�̐����^�C�~���O���s���ȏꍇ�A
			//	�d������C���X�^���X�����ꂽ����ɍ폜���邱�ƂőΉ�����
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
		//	�ŏ��ɃC���X�^���X���쐬
		Test t = new Test();
		t.setGreeting("Hello");
		t.say();

		//	�ȍ~�̓C���X�^���X�̍쐬�͂ł��Ȃ�
		Test ta = new Test();

		//	���ɑ��݂���C���X�^���X���Q��
		Test tb = Test.instance;
		tb.say();
	}
}

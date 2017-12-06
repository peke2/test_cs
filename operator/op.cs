//	operator 動作確認

using System;

class Test
{
	class TestOp
	{
		int _val;
		public TestOp(int a)
		{
			_val = a;
		}

		public static TestOp operator * (TestOp a, TestOp b)
		{
			return new TestOp(a._val * b._val);
		}

		public override string ToString()
		{
			return _val.ToString();
		}
	}

	static void Main()
	{
		TestOp op_a = new TestOp(5);
		TestOp op_b = new TestOp(3);

		Console.WriteLine(op_a * op_b);	//	15

		TestOp op_c = new TestOp(7);
		op_c *= op_b;					//	この形でもいける

		Console.WriteLine(op_c);		//	21
	}
}

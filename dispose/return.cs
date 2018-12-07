
using System;

namespace Test{

	class DisposeTest : IDisposable
	{
		public void Dispose()
		{
			Console.WriteLine("Disposed");
			GC.SuppressFinalize(true);
		}
	}


	class Test
	{
		static void Main()
		{
			Sub();
		}

		static void Sub()
		{
			using(var dis = new DisposeTest()){
				Console.WriteLine("In process...");
				//	usingの中でreturnしてもDisposeは呼び出されるか？ → 呼び出される
				return;
			}
			Console.WriteLine("Outside 'using'");
		}
	}
}


using System;

namespace Test{

	class DisposeTest : IDisposable
	{
		//	この関数は派生先のクラスでオーバーライドされるべきではない
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
			using(var dis = new DisposeTest()){
				Console.WriteLine("In process...");
			}
			Console.WriteLine("Outside 'using'");
		}
	}
}

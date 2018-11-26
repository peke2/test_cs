using System;
using System.Collections.Generic;
using System.Linq;

namespace MyTest{

	class Container
	{
		public string Name {get; private set;}
		public Container(string s)
		{
			Name = s;
		}
	}

	class TestLinq
	{
		static void Main()
		{
			var bases = new List<string>{
				"hello", "bye", "good morning", "see you", "good evening", "good night",
			};

			var list = new List<Container>();

			foreach(var s in bases)
			{
				list.Add( new Container(s) );
			}

			//	定義したクラスへのLinq条件判定適用
			IEnumerable<Container> query = list.Where(c=>c.Name.Contains("good"));
			foreach(Container c in query)
			{
				Console.WriteLine(c.Name);
			}

			//	結果をソート
			foreach(Container c in query.OrderBy(c=>c.Name))
			{
				Console.WriteLine(c.Name);
			}
		}
	}
}
using System;

class TestLambda
{
	//	宣言
	delegate bool MeetsCondition(int a, int b);

	//	情報参照先
	//	https://docs.microsoft.com/ja-jp/dotnet/articles/csharp/programming-guide/statements-expressions-operators/anonymous-functions

	static void Main()
	{
		//	匿名(anonymous)メソッド
		MeetsCondition	condDelegate = delegate(int a, int b){
			Console.WriteLine("delegate called");
			return (a == b);
		};

		//	ラムダ
		MeetsCondition	condLambda = (a,b)=>{
			Console.WriteLine("lambda called");
			return (a!=b);
		};

		bool	cond_result;
		cond_result = condDelegate(1,2);
		Console.WriteLine("anonymous result={0}", cond_result);

		cond_result = condLambda(1,2);
		Console.WriteLine("lambda result={0}", cond_result);

	}
}

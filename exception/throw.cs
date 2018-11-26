using System;

namespace MyTest
{
	class Test
	{
		public void call()
		{
			throw new Exception("テスト例外");
		}
	}

	class TestThrow
	{
		static void Main()
		{
			var test = new Test();
			try
			{
				test.call();
			}
			catch(Exception e)
			{
				Console.WriteLine(e.Message);

				throw;		//	そのまま例外を投げる → スタックトーレス情報は残る
				//throw e;		//	引数を投げる → スタックトレース情報がここからの分しか残らない

				//	上記の挙動の違いは以下のコンソール出力で確認
				//	トレース情報の違いに注目
				/*
				----------------
				■throw
				----------------
				テスト例外
				ハンドルされていない例外: System.Exception: テスト例外
				   場所 MyTest.Test.call()
				   場所 MyTest.TestThrow.Main()
				例外キャッチ終了

				----------------
				■throw e
				----------------
				テスト例外
				ハンドルされていない例外: System.Exception: テスト例外
				   場所 MyTest.TestThrow.Main()
				例外キャッチ終了
				*/
			}
			finally
			{
				Console.WriteLine("例外キャッチ終了");
			}
		}
	}
}
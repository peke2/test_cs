//	二次元配列を触ってみる

using System;

class Array2DTest
{
	struct Elem
	{
		public int x, y;
		public int value;
	}

	Elem[,]	elems;
	int ew, eh;

	static void Main()
	{
		Array2DTest a2d = new Array2DTest();

		a2d.array2d();
	}

	public void array2d()
	{
		int	w, h;
		w = 2;
		h = 3;
		initElems(w, h);

		outputElems();
		/*
		x=0, y=0, value=0
		x=0, y=0, value=0
		x=0, y=0, value=0
		x=0, y=0, value=0
		x=0, y=0, value=0
		x=0, y=0, value=0
		*/

		//	構造体を直接変更
		elems[1,2].value = 123;

		outputElems();
		/*
		x=0, y=0, value=0
		x=0, y=0, value=0
		x=0, y=0, value=0
		x=0, y=0, value=0
		x=0, y=0, value=0
		x=0, y=0, value=123
		*/

		//	構造体は値渡し　→　一時変数を介すると内容は変わらないはず
		Elem e = elems[0,1];
		e.x = 98;
		e.y = 12;

		outputElems();
		//	結果は変わらない
		/*
		x=0, y=0, value=0
		x=0, y=0, value=0
		x=0, y=0, value=0
		x=0, y=0, value=0
		x=0, y=0, value=0
		x=0, y=0, value=123
		*/

		/*
			クラスと構造体の選択
			https://msdn.microsoft.com/ja-jp/library/ms229017(v=vs.110).aspx

			以下の全ての条件を満たす場合に構造体を、そうじゃなければクラスを使うらしい

			・プリミティブ型のような単一の値を論理的に表す (int, 、double, などです。)。
			・16 バイト未満のサイズのインスタンスがあります。
			・変更可能なことはできません。
			・頻繁にボックス化することはありません。
		*/

	}

	public void initElems(int w, int h)
	{
		elems = new Elem[w, h];
		ew = w;
		eh = h;
	}

	public void outputElems()
	{
		for(int y=0; y<eh; y++)
		{
			for(int x=0; x<ew; x++)
			{
				Console.WriteLine("x="+elems[x,y].x+", y="+elems[x,y].y+", value="+elems[x,y].value);
			}
		}
		Console.WriteLine("--------");
	}

}

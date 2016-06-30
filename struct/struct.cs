//	構造体の確認

using	System;

[Serializable]
class Hello
{
	public int	value;

	public struct POS
	{
		public int	x;
		public int	y;
	}

	public POS	pos;

	public Hello()
	{
		value = 1;
		pos.x = 123;
		pos.y = 456;
	}

	public void init()
	{
		pos.x = 1;
	}

}

class Test
{
	static void Main()
	{
		Hello	h = new Hello();

		Console.WriteLine("pos x={0},y={1}", h.pos.x, h.pos.y);
	}
}

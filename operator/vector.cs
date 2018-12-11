//	operator 動作確認

using System;

class Test
{
	class Vector
	{
		public int x, y, z;
		public Vector(int x, int y, int z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		public Vector(Vector v) : this(v.x, v.y, v.z)
		{
		}

		public static Vector zero
		{
			get{return new Vector(0,0,0);}
		}

		public static Vector one
		{
			get{return new Vector(1,1,1);}
		}

		public static Vector operator + (Vector a, Vector b)
		{
			return new Vector(a.x + b.x, a.y + b.y, a.z + b.z);
		}

		public override string ToString()
		{
			return string.Format("[{0},{1},{2}]", x, y, z);
		}
	}

	static void Main()
	{
		Vector a = new Vector(Vector.zero);
		Vector b = new Vector(3,4,5);
		Vector c = Vector.one;
		Vector d = new Vector(13,11,19);

		Console.WriteLine(a + b);	//	[3,4,5]
		Console.WriteLine(b + c);	//	[4,5,6]
		Console.WriteLine(b + d);	//	[16,15,24]
	}
}

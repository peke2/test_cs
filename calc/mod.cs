using System;

//	浮動小数での剰余計算の確認
//	剰余は整数同士の計算時に求めるものだと思っていたので、浮動小数だとどうなるか確認
//	整数の剰余に小数点以下が付随する形
class Mod
{
	static public void Main()
	{
		float[,]	vals = new float[,]{
			{34.0f, 5.0f},	//34%5=4
			{22.3f, 4.0f},	//22.3%4=2.299999
			{4.3f, 2.0f}	//4.3%2=0.3000002
		};
		int		size = vals.Length/2;

		for(int i=0; i<size; i++)
		{
			float	c = vals[i,0] % vals[i,1];
			Console.WriteLine("{0}%{1}={2}", vals[i,0], vals[i,1], c);
		}
	}
}

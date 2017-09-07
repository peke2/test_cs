using System;

namespace TestString
{
	class Format
	{
		static void Main()
		{
			string str;

			int year, month, day;
			year = 1982;
			month = 7;
			day = 3;

			//これを知っていれば何とかなる主な使い方
			//{i,charnum}
				//i			変数のインデックス
				//charnum	表示文字数(少ない場合は空白で埋められる)
			//{i:d*}
			//{i:000}
				//i		変数のインデックス
				//d*	10進数の桁指定(桁に満たない場合、0で埋められる)
				//000	0プレースホルダー(0の部分を数値に置き換える)

			str = string.Format("{0:d4}-{1:d2}-{2:d2}", year, month, day);		//「1982-07-03」
			Console.WriteLine(str);

			str = string.Format("{0,6:00000}-{1:00}-{2,2}", year, month, day);	//「 01982-07- 3」
			Console.WriteLine(str);

			int value;

			value = 123456789;

			//{i:n*}
				//n*	nは「数値」を表す(付与された数字は小数点以下の桁数)
			str = string.Format("{0:n}", value);	//「123,456,789.00」
			Console.WriteLine(str);
			str = string.Format("{0:n0}", value);	//「123,456,789」
			Console.WriteLine(str);

			//	Microsoftのページよりも、以下のサイトの説明が分かりやすい
			//	https://dobon.net/vb/dotnet/string/inttostring.html
		}
	}
}

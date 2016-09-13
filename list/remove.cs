//	リストから削除

using System;
using System.Collections;
using System.Collections.Generic;

class ListRemoveTest
{
	struct PARAM
	{
		string	m_name;
		int		m_val;

		public PARAM(string name, int val)
		{
			m_name = name;
			m_val = val;
		}

		public bool isHit(string name)
		{
			if( name == m_name )	return	true;
			return	false;
		}

		public override string ToString()
		{
			return	"name["+m_name+"],val["+m_val.ToString()+"]";
		}

	}

	private static void writeList(List<PARAM> list)
	{
		foreach(PARAM p in list)
		{
			Console.WriteLine(p.ToString());
		}
	}

	public static void Main()
	{
		List<PARAM>	list = new List<PARAM>();
		list.Add(new PARAM("aaa", 123));
		list.Add(new PARAM("bbb", 4));
		list.Add(new PARAM("ccc", 78));
		list.Add(new PARAM("ddd", 956));

		Console.WriteLine("--------削除前");
		writeList(list);

		//	これはダメ
	/*	foreach(PARAM p in list)
		{
			if( true == p.isHit("bbb") )	list.Remove(p);
		}
		*/

		//	リストの要素の末尾からforループで要素を削除
	/*	for(int i=list.Count-1; i>=0; i--)
		{
			PARAM	p;
			p = list[i];
			if( true == p.isHit("bbb") )	list.Remove(p);
		}
		*/

		//	これで対応が一番すっきり
		list.RemoveAll(p => true == p.isHit("bbb"));

		Console.WriteLine("--------削除後");
		writeList(list);

	}
}

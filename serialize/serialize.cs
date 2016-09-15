using System;
using System.IO;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

using System.Collections.Generic;


//シリアライズの動作確認

[Serializable]
class Data
{
	//	シリアライズ→デシリアライズの確認用
	string		text = "Helllo";
	List<int>	list = new List<int>();

	//	オブジェクトが同じインスタンスを参照するかの確認用
	[Serializable]
	public class	PARAM
	{
		public string	comment;

		public PARAM(string s)
		{
			comment = s;
		}
	}
	public PARAM	refA = new PARAM("test");
	public PARAM	refB = null;


	public Data()
	{
		list.Add(5);
		list.Add(2);
		list.Add(1);
		list.Add(8);

		refB = refA;
	}

	public override string ToString()
	{
		string	s;
		s = "ListElements=";

		string[]	strs = new string[list.Count];
		for(int i=0; i<list.Count; i++)
		{
			strs[i] = list[i].ToString();
		}
		s += string.Join(",", strs);
		s += " / " + text;

		s += " / [A]=>" + refA.comment;
		s += " / [B]=>" + refB.comment;

		return s;
	}
}

class SerializeTest
{
	static void Main()
	{
		//	動作確認
	/*	Data	d = new Data();
		Console.WriteLine(d);
		//	参照先のオブジェクトが同じであることを確認
		d.refA.comment = "changed";
		Console.WriteLine(d);
	*/
		serialize();
		deserialize();
	}

	static void serialize()
	{
		FileStream		fs = new FileStream("DataFile.dat", FileMode.Create);
		Data	d = new Data();

		try
		{
			BinaryFormatter	formatter = new BinaryFormatter();
			formatter.Serialize(fs, d);
		}
		catch(SerializationException e)
		{
			Console.WriteLine("シリアライズ失敗["+e.Message+"]");
			throw;
		}
		finally
		{
			fs.Close();
		}
	}

	static void deserialize()
	{
		Data	d = null;
		FileStream	fs = new FileStream("DataFile.dat", FileMode.Open);

		try
		{
			BinaryFormatter	formatter = new BinaryFormatter();
			d = (Data)formatter.Deserialize(fs);
		}
		catch(SerializationException e)
		{
			Console.WriteLine("デシリアライズ失敗["+e.Message+"]");
			throw;
		}
		finally
		{
			fs.Close();
			Console.WriteLine(d);
			//	デシリアライズ後も同じオブジェクトを参照しているかの確認
			//	【結果】参照している
			//	シリアライズ → デシリアライズでも、参照の関係は変わらない(当り前か…)
			d.refA.comment = "changed";
			Console.WriteLine(d);
		}
	}

}

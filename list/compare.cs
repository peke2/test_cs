//	リストの比較

using System;
using System.Collections;
using System.Collections.Generic;


class Target
{
	public int value;
	public int add;
	public string name;

	public Target(int value, int add, string name)
	{
		this.value = value;
		this.add = add;
		this.name = name;
	}

	public bool Equals(Target other)
	{
		Console.WriteLine("this.value={0}/other.value={1}", this.value, other.value);
		if( this.value != other.value )	return	false;
		Console.WriteLine("this.add={0}/other.add={1}", this.add, other.add);
		if( this.add != other.add )		return	false;
		Console.WriteLine("this.name={0}/other.name={1}", this.name, other.name);
		if( this.name != other.name )	return	false;
		return	true;
	}
}


class Compare
{
	static void Main()
	{
		List<Target> list = new List<Target>();
		List<Target> expected = new List<Target>();
		list.Add( new Target(1, 5, "test") );
		list.Add( new Target(-4, 0, "sample") );
		list.Add( new Target(0, 71, "check") );
		list.Add( new Target(0, 0, "dummy") );

		expected.Add( new Target(1, 5, "test") );
		expected.Add( new Target(-4, 0, "sample") );
		expected.Add( new Target(0, 71, "check") );
		expected.Add( new Target(0, 0, "dummy") );

		int cnt = expected.Count;

		bool	is_equal = true;
		int		i = 0;
		foreach(Target t in list)
		{
			Target e = expected[i];
			i++;
			if( false == t.Equals(e) )
			{
				is_equal = false;
				break;
			}
		}

		Console.WriteLine("result={0}", is_equal);
	}
}

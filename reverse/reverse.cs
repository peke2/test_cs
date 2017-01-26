using System;

/*
exeファイルを逆コンパイルした時にどのように見えるか？
	クラス名		そのまま
	メンバー名		そのまま
	メソッド引数名	そのまま
	ローカル変数名	型やクラス名などが割り当てられる
*/

class Reverse	//	普通に名前が見れる
{
	static void Main()
	{
		Reverse	rev = new Reverse();	//	ローカル変数名は「reverse」に変更されていた → クラスのインスタンスはクラス名で全部小文字とかかな？
		int		result;
		result = rev.addToMember(789);
		Console.WriteLine("addToMember(789)の結果="+result.ToString());

		int		local;
		local = rev.getLocal();
		Console.WriteLine("getLocal()の結果="+local.ToString());

		int		check_for_ilspy = 97;		//	num
		int		addition_val = 34;			//	num2
		int		calc_result = 0;			//	num3
		calc_result = (check_for_ilspy * check_for_ilspy) / addition_val;

		Console.WriteLine("計算結果={0}", calc_result);
	}

	public	int	member_val;		//	普通に名前が見れる

	public Reverse()
	{
		member_val = 123;
	}

	//	メソッド名も全部そのまま見れる
	public int addToMember(int arg_val)
	{
		member_val += arg_val;	//	引数も名前が見れる
		return	member_val;
	}

	public int getLocal()
	{
		int	local_val;			//	最適化でローカル変数名が削除されて定数をreturnで返していた
		local_val = 456789;
		return	local_val;
	}

}
using System;

namespace HelloDotnet
{
    class LocalFunctionTest
    {
        //  C#7から使用可能になったローカル関数を書いてみた
        public int Add(int a, int b)
        {
            a = Mul();

            return a + b;

            //  ローカル関数(外部からのアクセスはできない)
            int Mul()
            {
                //  関数内の変数にアクセス可能
                return a * a;
            }
        }
    }
}
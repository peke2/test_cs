using System;
using System.Threading.Tasks;

namespace HelloDotnet
{
    class Program
    {
        // static async Task Main(string[] args)    //  async の Main() はC#7.1から可能
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            var prg = new Program();

            prg.runLocalFunctionTest();
            
        #if true
            //  呼び出し元で終了を待つパターン
            Task task = prg.runAsyncTestAsync();
            task.Wait();
        #else
            //  呼び出し先で終了を待つパターン
            prg.runAsyncTest();
        #endif
        }

        //  ローカル関数のテスト
        void runLocalFunctionTest()
        {
            var test = new LocalFunctionTest();

            int a = 12;
            int b = 3;
            var val = test.Add(a, b);
            Console.WriteLine($"{a}*{a}+{b}={val}");
        }

        //  Asyncのテスト
        //  使ってみた感じは、Unityのコルーチンと変わらない感じ
        //  使い方にもよるのかもしれない
        async Task runAsyncTestAsync()
        {
            var test = new AsyncTest();
            await test.updateAsync();
        }

        void runAsyncTest()
        {
            var test = new AsyncTest();
            test.update();
        }

    }
}

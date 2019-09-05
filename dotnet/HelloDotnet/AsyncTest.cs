using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

using System.Diagnostics;

namespace HelloDotnet
{
    public class AsyncTest
    {
        //  Microsoftのサンプルを元に、Asyncの確認コードを書いてみる
        // https://docs.microsoft.com/ja-jp/dotnet/csharp/programming-guide/concepts/async/
        // https://docs.microsoft.com/ja-jp/dotnet/api/system.runtime.compilerservices.asyncstatemachineattribute?view=netframework-4.8
        
        public async Task<int> async1()
        {
            await Task.Delay(5000);
            return 1;
        }

        public async Task<int> async2()
        {
            await Task.Delay(8000);
            return 2;
        }
    
        public async Task updateAsync()
        {
            Console.WriteLine("タスク実行開始(async)");

            var tasks = new List<Task>(){
                async1(), async2(),
            };
            
            var sw = new Stopwatch ();
            sw.Start();

            while(tasks.Any())
            {
                // 「await」を使う(Taskを作成する)と、メソッドに「async」の宣言と戻り値「Task」を定義しないといけない
                //  サンプルを参考に「Task.WhenAny()」を使ったが、このメソッド内で完結したい場合はどうやるのだろう？
                Task<int> finished = (Task<int>)await Task.WhenAny(tasks);
                if(finished.Result==1)
                {
                    var t = sw.ElapsedMilliseconds;
                    Console.WriteLine($"async1() is end [{t}ms経過]");
                }
                else if(finished.Result==2)
                {
                    var t = sw.ElapsedMilliseconds;
                    Console.WriteLine($"async2() is end [{t}ms経過]");
                }
                tasks.Remove(finished);
            }

            sw.Stop();
            Console.WriteLine("全タスク終了");
        }

        public void update()
        {
            Console.WriteLine("タスク実行開始");

            var tasks = new List<Task>(){
                async1(), async2(),
            };
            
            var sw = new Stopwatch ();
            sw.Start();

            //  タスクを返さないように変更
            //  明示的にタスクの実行などを行っていないがタスクは実行されているので、背後で動かしている？
            //  もしくは、タスクへの何らかのアクセスがあると、内部で実行が呼び出される？ → 実行呼び出し回数やタイミングの制御ができないので、この線は無さそう
            while(tasks.Any())
            {
                Task<int> task = null;
                foreach(var t in tasks)
                {
                    if( t.IsCompleted )
                    {
                        task = (Task<int>)t;
                        if(task.Result==1)
                        {
                            var et = sw.ElapsedMilliseconds;
                            Console.WriteLine($"async1() is end [{et}ms経過]");
                        }
                        else if(task.Result==2)
                        {
                            var et = sw.ElapsedMilliseconds;
                            Console.WriteLine($"async2() is end [{et}ms経過]");
                        }
                        break;
                    }
                }

                tasks.Remove(task);
            }

            sw.Stop();
            Console.WriteLine("全タスク終了");
        }

    }
}
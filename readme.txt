コンパイラは以下にあるcsc.exeを使用

C:\Windows\Microsoft.NET\Framework64\v4.0.30319

上記ディレクトリに予めパスを通しておくこと

コンパイル方法
csc test.cs


cygwin上からのコンパイル用シェル compile.sh を追加。
cscの出力がs-jisなのでiconvで出力をutf-8に変換している。

実行時も同様に

$ ./<実行ファイル> 2>&1 | iconv -f SJIS -t UTF8

とするとcygwin上の出力が正しく表示される。
そもそもutf8で出力すればいいのでは？ と思うけど、exe形式だからこうなってるのか？

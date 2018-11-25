#!/bin/sh

#コンパイルと実行を行うシェル
#Cygwin等で実行する場合に、標準出力の文字コードを変換する
#各作業ディレクトリから実行ファイル名を指定して実行
#拡張子は省略(ソースは「.cs」、実行ファイルは「.exe」で固定)
# [例]
# $ cd nullable
# $ ../run.sh nullable

filename=${1%.*}

../compile.sh $filename.cs
./$filename.exe 2>&1 | iconv -f SJIS -t UTF8

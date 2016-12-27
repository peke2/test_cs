#!/bin/sh

# cygwin上で .NET FrameworkのC#コンパイラにパスを通しておくこと
# 以下1行をユーザーの .bashrc に追加する
#
# PATH=/cygdrive/C/Windows/Microsoft.NET/Framework/v4.0.30319:$PATH
#
# ■追加先の使い分け
# ログイン時に1回だけ実行したい場合 → .bash_profile に追加
# シェルを起動するたびに実行したい場合 → .bashrc に追加

csc $1 2>&1 | iconv -f SJIS -t UTF8

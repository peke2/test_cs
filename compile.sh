#!/bin/sh

# cygwin上で .NET FrameworkのC#コンパイラにパスを通しておくこと
# PATH=/cygdrive/C/Windows/Microsoft.NET/Framework/v4.0.30319:$PATH

csc $1 2>&1 | iconv -f SJIS -t UTF8

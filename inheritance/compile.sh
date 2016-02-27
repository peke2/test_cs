#!/bin/sh

csc /out:inheritance.exe *.cs 2>&1 | iconv -f shift-jis -t utf-8
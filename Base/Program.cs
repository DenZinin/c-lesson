﻿int a = 4;
int b = 8;
int c = 12;
int d = 6;
int e = 10;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.WriteLine(max);
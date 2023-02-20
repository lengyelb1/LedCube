using System.Diagnostics;

int a = 3;
int b = 6;

Debug.Assert(a+b<10,(a+b)+" a két szám összege");

Debug.Assert(a%b == 0,"Nem osztható a két szám");

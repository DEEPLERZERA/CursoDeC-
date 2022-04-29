using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
Console.WriteLine("#########################################");

Console.WriteLine("Bem vindo ao programa de soma" .ToUpper());
int x = 16;
int y = 5;
int d = x + y;
int r = (int) Math.Pow(x, 2);
double raiz;
raiz = Math.Pow(x, 1.0/2.0);
int t = x % 2;
Console.WriteLine($"A soma de x + y é {d}");
Console.WriteLine("x exponencial = " + r);
Console.WriteLine("Raiz de 16 = " + raiz);
Console.WriteLine("Resto da divisao = " + t);


// See https://aka.ms/new-console-template for more information
double salario = 4500;

if (salario <= 2800)
{
    Console.WriteLine("o IR é de 7.5% e pode deduzir na declaração o valor de R$ 142");
}

else if (salario <= 3751)
{
    Console.WriteLine("o IR é de 15% e pode deduzir na declaração o valor de R$ 350");
}
else if (salario <= 4664)
{
    Console.WriteLine("o IR é de 22.5% e pode deduzir na declaração o valor de R$ 636");
}

Console.ReadLine();

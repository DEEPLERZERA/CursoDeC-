// See https://aka.ms/new-console-template for more information
ContaCorrente contaDaGabriela = new ContaCorrente();

contaDaGabriela.titular = "Gabriela";
contaDaGabriela.agencia = 862;
contaDaGabriela.numero = 565656;

Console.WriteLine(contaDaGabriela.titular);
Console.WriteLine("Agência: " + contaDaGabriela.agencia);
Console.WriteLine("Número: " + contaDaGabriela.numero);
Console.WriteLine("Saldo: " + contaDaGabriela.saldo);

Console.ReadLine();
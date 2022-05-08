// See https://aka.ms/new-console-template for more information
Console.WriteLine("Executando o projeto 10 - Calcula a poupança");

double valorInvestido = 1000;
int contadorMes = 1;

while(contadorMes <= 12)
{

    valorInvestido = valorInvestido + valorInvestido * 0.0036;
    Console.WriteLine("Após " + contadorMes + " meses, você terá R$" + valorInvestido);

    contadorMes++;

}
Console.ReadLine();
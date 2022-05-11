// See https://aka.ms/new-console-template for more information
for(int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
{
    for(int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
    {

        Console.WriteLine("*");
        if (contadorColuna >= contadorLinha)
            break;
    }
            
    Console.WriteLine();
}

for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
{
    for (int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
Console.ReadLine();


// See https://aka.ms/new-console-template for more information
Console.WriteLine("Executando o projeto 7 - Condicionais!");

int idadeJoao = 16;
int quantidadeDePessoas = 2;

if (idadeJoao >= 18)
{

    Console.WriteLine("Joao é maior de idade portanto pode entrar!");

}
else
{
    if (quantidadeDePessoas >= 2)
    {
        Console.WriteLine("Joao não é maior de idade porém, está acompanhado então pode entrar!");

    }
    else
    {
        Console.WriteLine("Joao apenas fique fora disso!");
    }
}

Console.ReadLine();
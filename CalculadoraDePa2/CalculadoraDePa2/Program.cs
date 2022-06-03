Console.WriteLine("Digite o termo: ");  //Imprimindo na tela
int termo = int.Parse(Console.ReadLine());  //Lendo input do usuario e passando pra inteiro
Console.WriteLine("Digite a razão: ");  //Imprimindo na tela do usuário 
int razao = int.Parse(Console.ReadLine());  //Lendo input do usuário e passando pra inteiro
Console.WriteLine("Digite a posição: ");
for (int x = int.Parse(Console.ReadLine()); x <= termo; x += razao)  //Para x igual a input do usuário e enquanto esse x for menor igual a termo então faça x += razao dada por usuário
{
    {
        Console.WriteLine("\n");  //Imprimindo valores com ESTILO
        Console.WriteLine("-----------------------");
        Console.WriteLine("\n" + "\n" + "          " + x);
    }
   
}

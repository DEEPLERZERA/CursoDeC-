// See https://aka.ms/new-console-template for more information

using _07_ByteBank;


ContaCorrente conta = new ContaCorrente(876, 3453534);  //Chamando método construtor e atribuindo valores

Console.WriteLine(ContaCorrente.TotalDeContasCriadas);  //Imprimindo total de ContaCriadas

Console.WriteLine(conta.agencia);  //Imprimindo na tela
Console.WriteLine(conta.numero);

ContaCorrente contaDaGabriela = new ContaCorrente(877, 3434324);

Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

Console.ReadLine();

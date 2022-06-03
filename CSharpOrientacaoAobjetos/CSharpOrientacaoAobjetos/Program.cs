// See https://aka.ms/new-console-template for more information
new ContaCorrente();  //chama função

ContaCorrente primeiraContaCorrente = new ContaCorrente();    //Instanciando novo objeto
primeiraContaCorrente.saldo = 200; //Atribui valor a objeto saldo
Console.WriteLine(primeiraContaCorrente.saldo);  //Imprime na tela

primeiraContaCorrente.saldo += 100;
Console.WriteLine(primeiraContaCorrente.saldo);

ContaCorrente SegundaContaCorrente = new ContaCorrente();  //Instanciando novo objeto
SegundaContaCorrente.saldo = 50;  //Atribuindo valor a  objeto saldo

Console.WriteLine("Primeira conta tem: " + primeiraContaCorrente.saldo);  //Imprimindo na tela
Console.WriteLine("Segunda conta tem: " + SegundaContaCorrente.saldo);



Console.ReadLine();

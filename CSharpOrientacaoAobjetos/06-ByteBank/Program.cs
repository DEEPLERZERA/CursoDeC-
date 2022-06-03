// See https://aka.ms/new-console-template for more information
using _06_ByteBank;

ContaCorrente conta = new ContaCorrente();

Cliente cliente = new Cliente();  //Chamando função Cliente

cliente.nome = "Guilherme";  //Atribuindo valores 
cliente.cpf = "434.564.879-20";
cliente.profissao = "Desenvolvedor";


conta.Saldo = -10;  //Chamando função de definir saldo
conta.titular = cliente;  //Atribuindo a titular os dados de cliente


Console.WriteLine(conta.titular.nome);  //Imprimindo na tela o nome do usuário
Console.WriteLine(conta.Saldo);  //Imprimindo na tela o saldo do usuário
Console.ReadLine();
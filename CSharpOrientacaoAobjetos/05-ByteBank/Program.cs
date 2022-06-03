// See https://aka.ms/new-console-template for more information
using _05_ByteBank;

//Cliente gabriela = new Cliente();  //Atribuindo a Gabriela função Cliente

//gabriela.nome = "Gabriela";  //Instanciando dados
//gabriela.profissao = "Desenvolvedora C#";
//gabriela.cpf = "434.562.878-20";

ContaCorrente conta = new ContaCorrente();



//conta.titular = gabriela;
conta.saldo = 500;
conta.agencia = 563;
conta.numero = 5634527;

//Console.WriteLine(gabriela.nome); //Imprimindo na tela o nome da Gabriela

//Console.WriteLine(conta.titular.nome);
//Console.WriteLine(conta.titular.cpf);
//Console.WriteLine(conta.titular.profissao);

Console.WriteLine(conta.titular);  //Imprime valor nulo pois titular não está apotando para nada

if (conta.titular == null)  //Se for nulo
{
    Console.WriteLine("Ops, a referência em conta.titular é NULL");  //Imprime na tela
}



/*conta.titular.nome = "Gabriela Costa"; //Instanciando um nome diferente para titular



Console.WriteLine(gabriela.nome); //Imprimindo
*/

Console.ReadLine(); 
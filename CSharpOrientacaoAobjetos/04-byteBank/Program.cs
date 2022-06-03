// See https://aka.ms/new-console-template for more information
ContaCorrente contaDoBruno = new ContaCorrente();  //Instanciando função ContaCorrente para bruno

contaDoBruno.titular = "Bruno";  

Console.WriteLine(contaDoBruno.saldo);

bool resultadoSaque = contaDoBruno.Sacar(50);  //Sacando dinheiro da conta de Bruno

Console.WriteLine(contaDoBruno.saldo);  //Imprimindo dados na tela
Console.WriteLine(resultadoSaque);

contaDoBruno.depositar(1500);  //Depositando saldo na conta de Bruno
Console.WriteLine(contaDoBruno.saldo);

ContaCorrente contaDaGabriela  = new ContaCorrente();  //Instanciando ContaCorrente para Gabriela

contaDaGabriela.titular = "Gabriela";

Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela.saldo);

contaDoBruno.Transferir(200, contaDaGabriela);  //Chamando função transferir, que passa dinheiro da conta de Bruno para a conta da Gabriela

Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela.saldo);

Console.ReadLine();
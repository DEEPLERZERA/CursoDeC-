namespace _05_ByteBank
{

public class ContaCorrente
{
    public Cliente titular;
    public int agencia;
    public int numero;
    public double saldo = 100;


    public bool Sacar(double valor)  //Criando função de sacar
    {
        if(this.saldo < valor)  //Se saldo, for menor do que valor não faça
        {
            return false;
        }
        else
        {
            this.saldo -= valor;  //caso contrário diminua o saldo de acordo com valor e retorne true
            return true;
        }
            
    }

    public void depositar(double valor) //Função de deposito
    {
        this.saldo += valor;
    }

    public bool Transferir(double valor, ContaCorrente contaDestino)  //Função de transferência bancaria
    {
        if (this.saldo < valor)
        {
            return false;
        }
            this.saldo -= valor;
            contaDestino.saldo += valor;  //ContaDestine recebe valor especificado
            return true;
        
    }
}

}
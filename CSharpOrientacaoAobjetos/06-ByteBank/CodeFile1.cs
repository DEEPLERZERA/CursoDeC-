namespace _06_ByteBank
{

public class ContaCorrente
{
    public Cliente titular { get; set; } //Definindo método de titular com get e set
    public int agencia { get; set; } //Definindo método de agencia com get e set
    public int numero { get; set; } ////Definindo método de numero com get e set
        
    private double _saldo = 100;  //Colocando saldo como private


  public double Saldo  //Criando método Saldo
        {
            get  //Se for pegar dados retorna o saldo
            {
                return _saldo;
            }
            set   //Se for setar faça
            {
                if(value < 0)  //Se valor menor que zero
                {
                    return;  //retorna vazio
                }
                _saldo = value;  //Caso contrário atribua saldo a valor
            }
        }



    public bool Sacar(double valor)  //Criando função de sacar
    {
        if(this._saldo < valor)  //Se saldo, for menor do que valor não faça
        {
            return false;
        }
        else
        {
            this._saldo -= valor;  //caso contrário diminua o saldo de acordo com valor e retorne true
            return true;
        }
            
    }

    public void depositar(double valor) //Função de deposito
    {
        this._saldo += valor;
    }

    public bool Transferir(double valor, ContaCorrente contaDestino)  //Função de transferência bancaria
    {
        if (this._saldo < valor)
        {
            return false;
        }
            this._saldo -= valor;
            contaDestino._saldo += valor;  //ContaDestine recebe valor especificado
            return true;
        
    }
}

}
namespace _07_ByteBank
{

public class ContaCorrente
{
    private int _Agencia;  //Atribuindo como private
    public Cliente titular { get; set; } //Definindo método de titular com get e set

    public static int TotalDeContasCriadas { get; private set; }  //Criando método de total de contas criadas com get e set como valor privado
    public int agencia   //Definindo método de agencia com get e set
        {



            get  //Se for pra pegar valor
            {

                return _Agencia;  //Retorne valor da Agência

            }

            set  //Se for pra settar
            {
                    if(value <= 0)  //Verifique se é menor ou igual a 0
                {
                    return;  //Caso positivo retorne nulo
                }

                    _Agencia = value;  //Caso negativo atribua valor de value
            }
        }           
    public int numero { get; set; } ////Definindo método de numero com get e set
        
    private double _saldo = 100;  //Colocando saldo como private



    public ContaCorrente(int Agencia, int Numero)  //Criando método construtor
        {
            agencia = Agencia;
            numero = Numero;

            TotalDeContasCriadas++;  //Aumento o número total de contas criadas
        }

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
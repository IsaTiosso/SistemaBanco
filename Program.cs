public class Conta
{//Conta 
    // declaração das variáveis com seus tipos de dado e acesso privado 
    private int agencia;
    private int numero;
    private string nomeCliente;
    private decimal valorDisponivel;

    public int Agencia
    {
        get { return agencia; }
        set
        {
            if (value.ToString().Length == 4)
            {
                agencia = value;
            }
            else
            {
                throw new ArgumentException("O código da agência deve ter 4 dígitos");

            }
        }
    }

    public int Numero
    {
        get { return numero; }
        set
        {
            if (value.ToString().Lenght == 8)
            {
                numero = value;
            }
            else
            {
                throw new ArgumentException("O número da conta deve ter 8 dígitos");
            }
        }

    }

    public string NomeCliente { get => nomeCliente; set => nomeCliente = value; }

}//Conta

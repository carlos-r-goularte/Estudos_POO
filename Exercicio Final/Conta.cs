namespace Exercicio_Final
{
    public class Conta
    {
        public string TitularConta { get; set; }
        public int NumeroConta { get; private set; }
        public double ValorConta { get; private set; }

        public Conta(string titular, int numero)
        {
            TitularConta = titular;
            NumeroConta = numero;
            ValorConta = 0.00;
        }
        public Conta(string titular, int numero, double valor) :this(titular,numero)
        {
            ValorConta = valor;
        }
        public void deposito(double quantia)
        {
            ValorConta += quantia;
        }
        public void saque(double quantia)
        {
            ValorConta -= quantia + 5.0;
        }
        public override string ToString()
        {
            return "Nome do Títular da conta: "
            + TitularConta
            + "  ||  Número da conta: "
            + NumeroConta
            + "  ||  Valor atual: R$"
            + ValorConta.ToString("F2");
        }
    }
}
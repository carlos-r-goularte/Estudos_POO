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
        private void deposito(double quantia)
        {
            
        }
        private void saque(double quantia)
        {

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
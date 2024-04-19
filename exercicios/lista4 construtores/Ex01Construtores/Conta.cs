namespace Ex01Construtores
{
    public class Conta
    {
        public Titular Titular { get; set; }
        public int Agencia { get; set; }
        public int NumeroDaConta { get; set; }
        public double Saldo { get; }
        public double Limite { get; set; }
        public string Informacoes => $"Conta nº {this.NumeroDaConta}, Agência {this.Agencia}, Titular: {this.Titular.Nome} - Saldo: {this.Saldo}";

        public Conta(Titular titular, int agencia, int numeroDaConta, double saldo, double limite)
        {
            Titular = titular;
            Agencia = agencia;
            NumeroDaConta = numeroDaConta;
            Saldo = saldo;
            Limite = limite;
        }
    }
}

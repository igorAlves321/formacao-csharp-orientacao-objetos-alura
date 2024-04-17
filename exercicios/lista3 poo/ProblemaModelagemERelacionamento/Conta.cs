namespace ProblemaModelagemERelacionamento
{
    public class Conta
    {
        public Titular Titular { get; set; }
        public int Agencia { get; set; }
        public int NumeroDaConta { get; set; }
        public double Saldo { get; set; }
        public double Limite { get; set; }

        public string Informacoes =>
            $"Conta nº {NumeroDaConta}, Agência {Agencia}, Titular: {Titular.Nome} - Saldo: {Saldo}";
    }
}

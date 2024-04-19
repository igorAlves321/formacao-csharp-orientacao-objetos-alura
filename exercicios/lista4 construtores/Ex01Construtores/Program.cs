using Ex01Construtores;

Titular titular = new Titular(" Igor Alves", "000.000.000-01", "Rua dos teste, Testando");
Conta c = new Conta(titular, 1, 2234, 100000, 5000);


Console.WriteLine(c.Informacoes);

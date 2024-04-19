using ScreenSound;

Episodio ep1 = new(4, "Técnicas de Facilitação", 45);
Console.WriteLine(ep1.Resumo);

Episodio ep2 = new(4, "Técnicas de Facilitação", 45);
ep2.AdicionarConvidado("Maria");
ep2.AdicionarConvidado("Marcelo");
Console.WriteLine(ep2.Resumo);

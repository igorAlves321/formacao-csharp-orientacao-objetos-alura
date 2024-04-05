//dicionário para armazenar as perguntas e as respostas.
Dictionary<string, string> perguntasERespostas = new Dictionary<string, string>
{
{ "Qual é a capital do Brasil?", "Brasília" },
{ "Quem escreveu a peça 'Romeu e Julieta'?", "William Shakespeare" }

};
// Apresente as perguntas aos usuários
foreach (var pergunta in perguntasERespostas.Keys)
{
Console.WriteLine(pergunta);
Console.Write("Sua resposta: ");
string respostaUsuario = Console.ReadLine();
if (perguntasERespostas[pergunta].Equals(respostaUsuario, 
StringComparison.OrdinalIgnoreCase))
{
Console.WriteLine("Você acertou!\n");
}
else
{
Console.WriteLine($"Resposta incorreta. A resposta correta é: {perguntasERespostas[pergunta]}\n");
}
}
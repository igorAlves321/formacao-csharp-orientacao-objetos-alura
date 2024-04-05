Dictionary<string, string> nomeEsenha = new Dictionary<string, string>
{
{ "abu", "123456" },
{ "boaaaaa", "abcdef" }
};
Console.Write("Nome de usuário: ");
string nomeUsuario = Console.ReadLine();
Console.Write("Senha: ");
string senhaUsuario = Console.ReadLine();

if (nomeEsenha.TryGetValue(nomeUsuario, out string senhaCorreta) && senhaUsuario == senhaCorreta)
{
Console.WriteLine("Você acertou! Senha correta.");
}
else
{
Console.WriteLine("Senha incorreta ou usuário não encontrado.");
}
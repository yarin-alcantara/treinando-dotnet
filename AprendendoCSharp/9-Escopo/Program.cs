Console.WriteLine("Executando o projeto 9");

int idadeCarlos = 19;
bool acompanhado = true;
string msgAdicional;

if (acompanhado == true)
{
    msgAdicional = "Carlos está acompanhado";
}
else
{
    msgAdicional = "Carlos não está acompanhado";
}
if (idadeCarlos >= 18 || acompanhado == false)

{
    Console.WriteLine("Acesso liberado.Pode entrar!");
    Console.WriteLine(msgAdicional);
}
else
{
    Console.WriteLine("Você não pode entrar.");
}
Console.ReadLine();
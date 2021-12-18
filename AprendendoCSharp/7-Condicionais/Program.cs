
Console.WriteLine("Executando o projeto 7");

int idadeCarlos = 16;
int quantidadePessoas = 2;

if (idadeCarlos >= 18)
{
    Console.WriteLine("Acesso liberado.Pode entrar!");
}
else
{
    if (quantidadePessoas >= 2)
    {
        Console.WriteLine("Acesso liberado, pois está acompanhado. Pode entrar");
    }
    else
    {
        Console.WriteLine("Você não pode entrar, você não é maior de idade");
    }
    
}
Console.ReadLine();
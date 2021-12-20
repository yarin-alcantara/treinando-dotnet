
ContaCorrente contaDaGabriela = new ContaCorrente();

contaDaGabriela.titular = "Gabriela";
contaDaGabriela.agencia = 555;
contaDaGabriela.numero = 9876564;
contaDaGabriela.saldo = 1000;


Console.WriteLine("Titular: "+contaDaGabriela.titular);
Console.WriteLine("Agência: "+contaDaGabriela.agencia);
Console.WriteLine("Número: "+contaDaGabriela.numero);
Console.WriteLine("Saldo: "+contaDaGabriela.saldo);

contaDaGabriela.saldo += 1000;
Console.WriteLine("Novo saldo: "+contaDaGabriela.saldo);

Console.ReadLine();




﻿ContaCorrente contaDoBruno = new ContaCorrente();

contaDoBruno.titular = "Bruno";

Console.WriteLine("Saldo: "+contaDoBruno.saldo);

bool resultadoSaque = contaDoBruno.Sacar(500);


Console.WriteLine(resultadoSaque);
Console.WriteLine(contaDoBruno.saldo);

contaDoBruno.Depositar(500);
Console.WriteLine(contaDoBruno.saldo);
 
ContaCorrente contaDaGabriela = new ContaCorrente();
contaDaGabriela.titular = "Gabriela";

Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela.saldo);

contaDoBruno.Transferir(200, contaDaGabriela);

Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela.saldo);

contaDaGabriela.Transferir(100, contaDoBruno);

Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
Console.WriteLine("Saldo da Gabriela: " + contaDaGabriela.saldo);
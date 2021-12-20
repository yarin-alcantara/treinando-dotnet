ContaCorrente contaDaGabriela = new ContaCorrente();

contaDaGabriela.titular = "Gabriela";
contaDaGabriela.agencia = 789;
contaDaGabriela.numero = 987456;
contaDaGabriela.saldo = 5000;

ContaCorrente contaDaGabrielaCosta = new ContaCorrente();
contaDaGabriela.titular = "Gabriela";
contaDaGabriela.agencia = 789;
contaDaGabriela.numero = 987456;
contaDaGabriela.saldo = 1000;

Console.WriteLine("Igualdade de tipo de referência: " + (contaDaGabriela == contaDaGabrielaCosta));

contaDaGabriela = contaDaGabrielaCosta;
Console.WriteLine("Igualdade de tipo de referência: " + (contaDaGabriela == contaDaGabrielaCosta));

contaDaGabriela.saldo = 300;
Console.WriteLine(contaDaGabrielaCosta.saldo);
Console.WriteLine(contaDaGabrielaCosta.saldo);

if(contaDaGabriela.saldo >= 100) {
    contaDaGabriela.saldo -= 100;

}




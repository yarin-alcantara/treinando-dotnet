﻿
Console.WriteLine("Executando projeto 10 - Calcula poupança \n");

double valorInvestido = 1000;

int contadorMes = 1;
while(contadorMes <= 12)
{
    valorInvestido = valorInvestido + valorInvestido * 0.0036;
    Console.WriteLine("Após" +contadorMes + "meses terá R$" + valorInvestido);
    contadorMes++;
}

Console.ReadLine();


Console.WriteLine("Executando projeto 11 - Calcula poupança \n");

int contadorMes;
double valorInvestido = 1000;

for (contadorMes = 1 ; contadorMes <= 12; contadorMes++){

    valorInvestido *= 1.0036;
    Console.WriteLine("Após " + contadorMes + " meses terá R$" + valorInvestido);
}
Console.ReadLine();

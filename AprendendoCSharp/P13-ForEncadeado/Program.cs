
Console.WriteLine("Executando projeto 13 - For Encadeado \n");

// criando um desenho com asteriscos
for(int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
{
    for (int contadorColuna = 0; contadorColuna < 10 ; contadorColuna++)
    {
        Console.Write("*");
        if (contadorColuna >= contadorLinha)
            break;
    }
    Console.WriteLine();
}
Console.WriteLine();

//Uma forma diferente de fazer o desenho
for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
{
    for (int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)
    {
        Console.Write("*");
   
    }
    Console.WriteLine();
}
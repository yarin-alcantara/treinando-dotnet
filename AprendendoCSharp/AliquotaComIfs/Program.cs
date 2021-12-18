
double salario = 4000;

if (salario >= 1900.0 && salario <= 2800.0)
{
    double salarioMenosIR = salario - 142.0;
    Console.WriteLine("A aliquota é de 7,5% e vai ser dedudizo" +
        " R$142,00 do seu salario, dando um total de: R$" + salarioMenosIR);
}
else if (salario >= 2800.01 && salario <= 3751.0)
{
    double salarioMenosIR = salario - 350.0;
    Console.WriteLine("A aliquota é de 15% e vai ser dedudizo" +
        " R$350,00 do seu salario, dando um total de: R$" + salarioMenosIR);
}
else if (salario >= 3751.01 && salario <= 4664.0)
{
    double salarioMenosIR = salario - 636.0;
    Console.WriteLine("A aliquota é de 22,5% e vai ser dedudizo" +
        " R$636,00 do seu salario, dando um total de: R$" + salarioMenosIR);
}
else
{
    Console.WriteLine("Você não terá IR deduzido");
}

Console.ReadLine();
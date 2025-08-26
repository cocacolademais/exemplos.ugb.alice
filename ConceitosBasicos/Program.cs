/*
try
{
    Console.WriteLine("Informe seu nome: ");
    string nome = Console.ReadLine();
    Console.WriteLine("Informe seu salário: ");
    decimal salario = decimal.Parse(Console.ReadLine());
    Console.WriteLine("Seja bem-vinda(o) {0}, o salário informado foi {1:C3}", nome, salario);

    //informem o valor do IRPF a ser pago de acordo com o salário informado. Utilize a tabela real de desconto de IRPF
    decimal irpfDevido;
    if (salario <= 2259.20m)
        irpfDevido = 0;
    else if (salario <= 2826.65m)
        irpfDevido = salario * 0.075m - 169.21m;
    else if (salario <= 3751.05m)
        irpfDevido = salario * 0.15m - 381.44m;
    else if (salario <= 4664.68m)
        irpfDevido = salario * 0.225m - 662.77m;
    else
        irpfDevido = salario * 0.275m - 896m;

    Console.WriteLine($"Para o salário de {salario} o valor a ser pago de IRPF é {irpfDevido}, então o salário com desconto de IRPF será {salario - irpfDevido}");
}
catch (FormatException)
{
    Console.WriteLine("O salário deve ser informado em formato numérico.");
}
catch (Exception e)
{
    Console.WriteLine("Ocorreu um erro. Contate o suporte técnico.");
    Console.WriteLine(e.StackTrace);
}
*/

using ConceitosBasicos.uteis;
int opcao;
do
{
    Console.WriteLine("[0] - sair");
    Console.WriteLine("[1] - somar dois números");
    Console.WriteLine("[2] - Converter metros para milimetros");
    Console.WriteLine("[3] - Calcular aumento de salario");
    Console.WriteLine("Escolha uma operação:");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:

            SomaDoisNumeros somaDoisNumeros = new SomaDoisNumeros();
            int resultado = somaDoisNumeros.Somar(20, 22);
            Console.WriteLine(resultado);
            break;

        case 2:

            int milimetros = MetrosMilimetros.Converter(2);
            Console.WriteLine(milimetros);
            break;

        case 3:
            CalculaAumento calculaAumento = new CalculaAumento();
            Console.Write("informe o salário");
            decimal salario = Convert.ToDecimal(Console.ReadLine());
            Console.Write("informe o percentual de aumento:");
            float percentual = float.Parse(Console.ReadLine());
            decimal percentualAumento = calculaAumento.Calcular(salario, percentual);
            Console.WriteLine($"Para o salário {salario:c2}, o aumento de {percentual:f2} corresponde a {percentualAumento}");
            Console.WriteLine($"O novo salário é {salario + percentualAumento}");
            break;
        default:
            Console.WriteLine("opcao invalida!");
            break;
    }
}
 while (opcao != 0) ;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Determine o valor do primeiro numero: ");
if(double.TryParse(Console.ReadLine(),out double valor1))

{
    Console.Write("Determine o valor do segundo numero: ");
    if(double.TryParse(Console.ReadLine(),out double valor2))

    {
        Console.Write("Informar o operador:");
        string operador = Console.ReadLine();
        double resultado = 0;
        switch (operador)

        {
            case "+":
                   resultado = valor1 + valor2;
                   Console.WriteLine($"O resultado da soma é:{resultado}");

                   break;

            case "-":
                   resultado = valor1 - valor2;
                   Console.WriteLine($"O resultado da subtracao é:{resultado}");

                   break;

            case "*":
                   resultado = valor1 * valor2;
                   Console.WriteLine($"O resultado da multiplicacao é:{resultado}");

                   break;

            case "/":
                   resultado = valor1 / valor2;
                   Console.WriteLine($"O resultado da divisao é:{Math.Round(resultado,2)}");//Math.Round(variavel,2);
                   break;
        }
    }
}
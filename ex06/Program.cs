// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite o primeiro número");
int N1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o sengundo número");
int N2 = int.Parse(Console.ReadLine());

Console.Clear();

Console.WriteLine($"A soma é: {N1 + N2}");
Console.WriteLine($"A subtração é: {N1 - N2}");
Console.WriteLine($"A multiplicação é: {N1 * N2}");

if (N2 != 0)
{
    Console.WriteLine("A divisão é: " + (N1 / N2));
}

else
{
    Console.WriteLine("A divisão não é permitida");
}

Console.WriteLine("---------------------");
Console.WriteLine($"Os números são iguais? {N1 == N2}");
Console.WriteLine($"Número 1 é maior Número 2? {N1 > N2}");
Console.WriteLine($"Número 1 é menor Número 2? {N1 < N1}");
Console.WriteLine($"Número 1 é maior igual ao número2? {N1 >= N2}");
Console.WriteLine($"Número 1 é menor igual ao número 2? {N1 <= N2}");
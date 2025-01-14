// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite o primeiro número");
int N1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o sengundo número");
int N2 = int.Parse(Console.ReadLine());

Console.Clear();

Console.WriteLine("=======================");
Console.WriteLine("=== SOMA DE NÚMEROS ===");
Console.WriteLine("=======================");

Console.Write($"A soma dos valores é: {N1 + N2}");
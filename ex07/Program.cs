Console.WriteLine("Digite a sua primeira nota: ");
float n1  = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a sua segunda nota: ");
float n2 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a sua terceira nota: ");
float n3 = float.Parse(Console.ReadLine());

Console.WriteLine($"A média da sua nota é: {(n1 + n2 + n3) / 3}");
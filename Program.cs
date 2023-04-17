// Faça um programa que leia 10 valores digitados pelo usuário e no final, escreva o maior e o
// menor valor lido.

int menor = int.MaxValue;
int maior = int.MinValue;

for (var i = 1; i <= 10; i++)
{
    Console.WriteLine($"Informe o {i}º valor:");
    int valor = int.Parse(Console.ReadLine());

if (valor < menor)
{
    menor = valor;
}
else if (valor > maior)
{
    maior = valor;
}
}

Console.WriteLine($"O menor valor lido é {menor}");
Console.WriteLine($"O maior valor lido é {maior}");
using System;

class Program {
    static void Main() {
        Console.Write("Digite o seu ano de nascimento: ");
        int anoNascimento = int.Parse(Console.ReadLine());
        int idade = 2024 - anoNascimento;
        Console.WriteLine($"Você tem {idade} anos.");
    }
}

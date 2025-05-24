using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("--- Forca ---");
        Console.Write("Qual a palavra secreta? ");
        string palavra = Console.ReadLine()!;

        Console.Write("Qual a letra? ");
        string letra = Console.ReadLine()!;

        bool existe = palavra.ToLower().Contains(letra.ToLower());

        Console.WriteLine($"A letra \"{letra}\" existe na palavra secreta => {existe}");
    }
}

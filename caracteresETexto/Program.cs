class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 5 - caracteres e textos");

        char letra = (char)65;
        Console.WriteLine(letra);

        letra = (char)(65 + 1);
        Console.WriteLine(letra);

        string primeiraFrase = "Curso de Tech ";
        Console.WriteLine(primeiraFrase + 2022);
        // O @ ajuda a fazer a listagem da string.
        string contando = @"contar ém até: 
        1 
        2 
        3 
        4";
        Console.WriteLine(contando);

        Console.WriteLine("Tecle enter para fechar... ");
        Console.ReadLine();
    }
   }